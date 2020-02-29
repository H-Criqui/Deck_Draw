using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CardPrefab;
    public GameObject deck_area;
    public PokerDeck _deck;
    private Deck _temp;
    private Deck _temp2;
    // Start is called before the first frame update
    void Start()
    {
        _deck = new PokerDeck();
    }

    //Draws top card from deck and displays it on the screen
   
    public void DrawTopCard()
    {
        if (CardPrefab != null)
        {
            var card = GameObject.Instantiate<GameObject>(CardPrefab, Vector3.zero, Quaternion.identity);
            card.transform.SetParent(deck_area.transform, false);
            var controller = card.GetComponent<CardController>();

            //attach card C# object to card Unity object
            controller.Card = _deck.RemoveFromTop();

            if (controller != null)
            {
                controller.FaceMaterial = PokerCardFactory.GetInstance().Materials[controller.Card.Name];
                controller.UpdateFaceMaterial();
            }
            Debug.Log("Card Grabbed: " + controller.Card.Name);
        }
    }

    public void DrawBottomCard()
    {
        if (CardPrefab != null)
        {
            var card = GameObject.Instantiate<GameObject>(CardPrefab, Vector3.zero, Quaternion.identity);
            card.transform.SetParent(deck_area.transform, false);
            var controller = card.GetComponent<CardController>();

            //attach card C# object to card Unity object
            controller.Card = _deck.RemoveFromBottom();

            if (controller != null)
            {
                controller.FaceMaterial = PokerCardFactory.GetInstance().Materials[controller.Card.Name];
                controller.UpdateFaceMaterial();
            }
            Debug.Log("Card Grabbed: " + controller.Card.Name);
        }
    }
    
   
    public int numberOfDecks = 1;
    public void addDeck()
    {
        PokerDeck temp = new PokerDeck();
        while (!temp.empty())
        {
            _deck.AddToTop(temp.RemoveFromTop());
        }
        numberOfDecks += 1;
        Debug.Log("Deck Added, Number of Decks: " + numberOfDecks);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
