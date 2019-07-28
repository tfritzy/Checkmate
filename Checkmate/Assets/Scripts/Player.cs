using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    protected Tilemap tileMap;

    public void MoveTo(Vector3Int destination)
    {
        this.transform.position = destination;

    }

    private void SetupLogic()
    {
        this.tileMap = GameObject.Find("Map").GetComponentInChildren<Tilemap>();
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
    }
}
