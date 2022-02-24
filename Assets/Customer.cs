using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : Interactable
{
    public Pizza pizza;
    public int patience{ get; set; }
    public Customer()
    {
        //summons a new Customer
        //animation for entering the restaraunt
        Debug.Log("customer constructor");
        
        patience = 100;
    }
    public void Start()
    {
        pizza = new Pizza();
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
        StartCoroutine(startOrder());
        

        Debug.Log(""+pizza.getIngredients());
        List<Ingredient> ingredients = pizza.getIngredients();

        for (int i = 0; i < ingredients.Count; i++)
        {
            Debug.Log("inside forloop");
            StartCoroutine(Wait(ingredients, i));
           


        }
        Debug.Log("done");
    }
    
    IEnumerator startOrder()
    {
        FindObjectOfType<AudioManager>().Play("startorder" + Random.Range(1f, 1f));
        yield return new WaitForSeconds(3f);
    }
    IEnumerator Wait(List<Ingredient> ingredients, int i)
    {
        FindObjectOfType<AudioManager>().Play(ingredients[i].getName() + "1");
        yield return new WaitForSeconds(1f);
        
    }
}
