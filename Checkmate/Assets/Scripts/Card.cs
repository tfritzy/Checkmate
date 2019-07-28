using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour, IClickable
{
    public GameObject MovementDecoration;
    public string CardName;
    public List<Vector2Int> MovementTileOptions;
    public Player player;
    protected Zones zones;

    public void CardPlayed()
    {
        this.zones.CardPlayed(this.gameObject);
    }

    public void Setup(Zones zones, Player player)
    {
        this.zones = zones;
        this.player = player;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowTactics()
    {
        foreach (Vector2Int movementTileOption in MovementTileOptions)
        {
            Vector3 tileDelta = new Vector3(movementTileOption.x, movementTileOption.y, 0);
            Vector3 displayLocation = player.transform.position + tileDelta;
            GameObject decorator = GameObject.Instantiate(MovementDecoration, displayLocation, new Quaternion(), null);
            decorator.GetComponent<MovementDecorator>().Setup(this.player, this);
        }
    }

    public void Click()
    {
        Debug.Log("I got clicked!");
        ShowTactics();
    }
}
