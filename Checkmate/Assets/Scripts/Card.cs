using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour, IClickable
{
    public GameObject MovementDecoration;
    public List<Vector2Int> MovementTileOptions;
    protected Player player;

    public void Setup(Player player)
    {
        this.player = player;
    }

    public Card(Player player)
    {
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
        }
    }

    public void Click()
    {
        Debug.Log("I got clicked!");
        ShowTactics();
    }
}
