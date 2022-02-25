using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orders_Note : MonoBehaviour
{
    public Image hand;
    public Sprite orderNotePic;
    public Pizza curPizza { get;  set; }
    public void takeOrder()
    {
        hand.sprite = orderNotePic;
    }

    public void submit()
    {
        hand.sprite = null;
    }
}
