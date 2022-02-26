using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : Interactable
{
    public Pizza pizza;
    public int patience{ get; set; }
    public LevelDifficulty poopoo;
    public string sigma;
    public Customer()
    {
        //summons a new Customer
        //animation for entering the restaraunt
        Debug.Log("Customer spawned");
        patience = 100;
    }
    public void Start()
    {
        if (Random.Range(1, 3) == 1)
        {
            sigma = "M";
        }
        else
        {
            sigma = "F";
        }
        sigma = "F";
        Debug.Log("before pizza constructor: " + poopoo);
        pizza = new Pizza(poopoo);
    }
    public void leave()
    {
        //animation for leaving restaraunt
        Debug.Log("CUSTOMER LEFT");
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
        


        //Debug.Log(pizza.ToString());
        List<Ingredient> ingredients = pizza.getIngredients();
        StartCoroutine(StartOrder(ingredients));
        
        Debug.Log("done");
    }
    
    IEnumerator StartOrder(List<Ingredient> ingredients)
    {
        FindObjectOfType<AudioManager>().Play("startorder" + Random.Range(1,2));
        yield return new WaitForSeconds(2f);
        Debug.Log("wait");
        StartCoroutine(WaitBeforeEachIngredient(ingredients));
        
        Debug.Log("outsideLoop");
    }
    IEnumerator WaitBeforeEachIngredient(List<Ingredient> ingredients)
    {
        for (int j = 0; j < ingredients.Count; j++)
        {
            Debug.Log("nside forloop");
            Debug.Log("waitbeforeeachbefore");
            FindObjectOfType<AudioManager>().Play(ingredients[j].getName() + Random.Range(1,4)+getGender());
            yield return new WaitForSeconds(1.69f);
            Debug.Log("waitbeforeeachafter");
            Debug.Log("donewithloop");



        }
        
        



    }

    public string getGender()
    {
        return sigma;
    }
}
