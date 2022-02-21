using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    private Ingredient[] ingredients;
    private int numToppings = Random.Range(1,4);
    private string[] possibleLocations = { "The White House", "Blake Avenue", "Andale Drive", "Andover Road", "Dovedale South", "Durham Way North" };
    private string[] possibleSizes = { "large", "medium", "small" };
    private string location;
    private string size;

    //precondition: Must call on pizza class
    //postcondition: generates random toppings and a random location for a specific pizza.
    public Pizza()
    {
        System.Random rnd = new System.Random();
        for (int i = 0; i < numToppings; i++)
        {
            //toppings[i] = new Ingredient();
        }
        location = possibleLocations[rnd.Next(5)];
        size = possibleSizes[rnd.Next(2)];
    }

    public Pizza(string tp, string lc, string sz) {
       // toppings = tp;
        location = lc;
        size = sz;
    }



}
