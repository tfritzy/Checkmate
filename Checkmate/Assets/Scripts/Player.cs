using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public List<Card> Hand;
    public List<Card> Deck;
    protected Tilemap tileMap;
    public GameObject Rush;

    public void MoveTo(Vector3Int destination)
    {
        this.transform.position = destination;

    }


    private void SetupLogic()
    {
        this.tileMap = GameObject.Find("Map").GetComponentInChildren<Tilemap>();
        CardInitialize();
    }
    private void DeckInitialize()
    {
        this.Deck = new List<Card>();
        for (int i = 0; i < 10; i++)
        {
            Card card = new Rush(this);
            Deck.Add(card);
        }

    }
    private void HandInitialize()
    {
        for (int i = 0; i < 3; i++)
        {
            Card card = Deck[Deck.Count - 1];
            Hand.Add(card);
            Deck.RemoveAt(Deck.Count - 1);
            GameObject cardInst = GameObject.Instantiate(this.Rush, new Vector2(i - 1, -3), new Quaternion(), null);
            cardInst.GetComponent<Card>().Setup(this);
        }
    }
    private void CardInitialize()
    {
        DeckInitialize();
        HandInitialize();
    }
    // Start is called before the first frame update
    void Start()
    {
        SetupLogic();
    }
    void ButtonClicked(int buttonNo)
    {
        Debug.Log("Button clicked = " + buttonNo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellposition = tileMap.WorldToCell(clickPosition);
            this.transform.position = tileMap.GetCellCenterWorld(cellposition);
        }
    }
}
