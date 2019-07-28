using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardFactory
{
    private GameObject rush;
    private GameObject knightmove;

    public CardFactory()
    {
        LoadCards();
    }

    private void LoadCards()
    {
        this.rush = Resources.Load<GameObject>("Prefab/Cards/Rush");
        this.knightmove = Resources.Load<GameObject>("Prefab/Cards/Knight Move");
    }
    public GameObject GenerateCard(string cardName)
    {
        if (cardName.Equals("Rush", System.StringComparison.OrdinalIgnoreCase))
        {
            return this.rush;
        }
        else if (cardName.Equals("KnightMove", System.StringComparison.OrdinalIgnoreCase))
        {
            return this.knightmove;
        }
        else
        {
            throw new System.ArgumentException("Given card name does not corpsepond to a card. Given cardname = " + cardName);
        }
    }
}
