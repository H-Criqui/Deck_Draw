using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject manager; 
    public void OnClick()
    {
        int cut = (Random.Range(0, 12) + 20) * manager.GetComponent<GameManager>().numberOfDecks;
        Deck _temp = new Deck();
        Deck _temp2 = new Deck();

        for (int i = 0; i < cut; i++)
        {
            _temp.AddToBottom(manager.GetComponent<GameManager>()._deck.RemoveFromTop());
        }
        while (!manager.GetComponent<GameManager>()._deck.empty())
        {
            _temp2.AddToBottom(manager.GetComponent<GameManager>()._deck.RemoveFromTop());
        }

        while (!_temp.empty() || !_temp2.empty())
        {
            if (!_temp.empty())
            {
                manager.GetComponent<GameManager>()._deck.AddToTop(_temp.RemoveFromTop());
            }
            if (!_temp2.empty())
            {
                manager.GetComponent<GameManager>()._deck.AddToTop(_temp2.RemoveFromTop());
            }
        }
        Debug.Log("Deck Shuffled: " + manager.GetComponent<GameManager>()._deck);
    }
}
