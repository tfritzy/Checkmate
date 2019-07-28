using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<GameObject> Cards;

    public Hand()
    {
        this.Cards = new List<GameObject>();
    }

    public void ShiftCards()
    {
        int xposition = -2;
        foreach (GameObject card in this.Cards)
        {
            card.transform.position = new Vector2(xposition, -3);
            xposition += 2;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
