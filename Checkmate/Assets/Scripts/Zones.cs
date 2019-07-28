using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones : MonoBehaviour
{
    public Deck deck;
    public Discard discard;
    public Hand hand;
    private CardFactory cardFactory;
    public Player player;


    // Start is called before the first frame update
    void Start()
    {
        this.deck = new Deck();
        this.discard = new Discard();
        this.hand = new Hand();
        this.cardFactory = new CardFactory();
        this.player = GameObject.Find("Player").GetComponent<Player>();
        CardInitialize();
    }

    private void HandInitialize()
    {
        CardFactory cardFactory = new CardFactory();
        for (int i = 0; i < 3; i++)
        {
            DrawCard();
        }
    }
    private void DeckInitialize()
    {
        this.deck.Cards.AddRange(new string[] {

            "rush",
            "knightmove",
            "knightmove",
            "rush"
        });
    }

    public void CardPlayed(GameObject cardPlayed)
    {
        DiscardCard(cardPlayed);
        DrawCard();

    }

    public void DiscardCard(GameObject cardToDiscard)
    {
        int cardToDiscardPosition = -1;
        for (int i = 0; i < this.hand.Cards.Count; i++)
        {
            GameObject card = this.hand.Cards[i];
            if (card == cardToDiscard)
            {
                cardToDiscardPosition = i;
            }
        }
        if (cardToDiscardPosition == -1)
        {
            throw new System.ArgumentException("Cannot discard a card that does not exist in the hand!");
        }
        this.hand.Cards.RemoveAt(cardToDiscardPosition);
        this.discard.Cards.Add(cardToDiscard.GetComponent<Card>().CardName);
        Destroy(cardToDiscard);
        this.hand.ShiftCards();
    }


    public void DrawCard()
    {
        if (deck.Cards.Count == 0)
        {
            AddDiscardToDeck();
        }
        GameObject card = cardFactory.GenerateCard(this.deck.Cards[this.deck.Cards.Count - 1]);
        this.deck.Cards.RemoveAt(this.deck.Cards.Count - 1);
        GameObject cardInst = GameObject.Instantiate(card, new Vector2(this.hand.Cards.Count * 2 - 2, -3), new Quaternion(), null);
        cardInst.GetComponent<Card>().Setup(this, this.player);
        this.hand.Cards.Add(cardInst);
    }
    public void AddDiscardToDeck()
    {
        this.deck.Cards.AddRange(this.discard.Cards);
        this.discard.Cards = new List<string>();
    }
    private void CardInitialize()
    {
        DeckInitialize();
        HandInitialize();
    }
}
