using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDecorator : MonoBehaviour, IClickable
{
    private Card parentCard;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        InputController.OnClickMiss += DecorationKill;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnDestroy()
    {
        InputController.OnClickMiss -= DecorationKill;
    }
    public void Setup(Player player, Card parentCard)
    {
        this.player = player;
        this.parentCard = parentCard;
    }

    public void Click()
    {
        player.transform.position = this.transform.position;
        this.parentCard.CardPlayed();
        DecorationKill();
    }
    public void DecorationKill()
    {
        GameObject[] decorator = GameObject.FindGameObjectsWithTag("Decorator");
        for (int i = 0; i < decorator.Length; i++)
        {
            Destroy(decorator[i]);
        }
    }
}

