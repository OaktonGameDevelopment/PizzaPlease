using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orders_Note : MonoBehaviour
{
    public GameObject hand;
    public Pizza curPizza { get;  set; }
    public void takeOrder()
    {
        hand.SetActive(true);
    }

    public void submit()
    {
        hand.SetActive(false);
    }
}
