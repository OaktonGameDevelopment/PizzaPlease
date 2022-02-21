using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : Interactable
{
    public int patience{ get; set; }
    public Customer()
    {
        //summons a new Customer
        //animation for entering the restaraunt
        patience = 100;
    }
    public void leave()
    {
        //animation for leaving restaraunt
        Destroy(gameObject);
    }
    public void decresePatience()
    {
        patience--;
        gameObject.GetComponent<MeshRenderer>().material.color += Color.red;
    }
    protected override void interact() 
    {
        //start interaction with customer
        Debug.Log("interact with customer");
    }
}
