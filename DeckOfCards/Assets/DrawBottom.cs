using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBottom : MonoBehaviour
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
        manager.GetComponent<GameManager>().DrawBottomCard();
    }
}
