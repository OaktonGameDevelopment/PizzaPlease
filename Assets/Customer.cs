using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : Interactable
{
    public int patience;
    public Customer()
    {
        //summons a new Customer
        //animation for entering the restaraunt
    }
    public void leave()
    {
        //animation for leaving restaraunt
    }
    protected override void interact() 
    {
        //start interaction with customer
    }
}
