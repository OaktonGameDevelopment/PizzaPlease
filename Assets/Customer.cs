using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : Interactable
{
    public float patience{ get; set; }
    public Customer()
    {
        //summons a new Customer
        //animation for entering the restaraunt
        patience = 100;
    }
    public void leave()
    {
        //animation for leaving restaraunt
        Debug.Log("CUSTOMER LEFT");
        Destroy(gameObject);
    }
    public void decresePatience()
    {
        Debug.Log("customer patience: " + patience);
        patience--;
        gameObject.GetComponent<MeshRenderer>().material.color += Color.red;
    }
    protected override void interact() 
    {
        //start interaction with customer
        Debug.Log("interact with customer");
    }
}
