using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : Interactable
{
    public Pizza pizza = new Pizza();
    public int patience{ get; set; }
    public Customer()
    {
        //summons a new Customer
        //animation for entering the restaraunt
        pizza = new Pizza();
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
        FindObjectOfType<AudioManager>().Play("startorder" + Random.Range(1f, 1f));
        
        this.pizza.toAudio();
        Debug.Log("done");
    }
}
