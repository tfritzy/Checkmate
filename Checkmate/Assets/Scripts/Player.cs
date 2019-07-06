using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public List<Card> Hand;
    protected Tilemap tileMap;

    public void MoveTo(Vector3Int destination)
    {
        this.transform.position = destination;

    }


    private void Initialize()
    {
        this.tileMap = GameObject.Find("Map").GetComponentInChildren<Tilemap>();
        this.Hand = new List<Card>();
        this.Hand.Add(new Rush(this));
        Card card = GameObject.Find("Rush").AddComponent<Rush>() as Rush;
        card = new Rush
    }
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
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
