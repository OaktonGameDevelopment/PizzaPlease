using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza
{
    private List<Ingredient> ingredients = new List<Ingredient>();
    private int numToppings = Random.Range(1,4);
    bool real;
    //private string[] possibleLocations = { "The White House", "Blake Avenue", "Andale Drive", "Andover Road", "Dovedale South", "Durham Way North" };
    //private string[] possibleSizes = { "large", "medium", "small" };
    

    //precondition: Must call on pizza class
    //postcondition: generates random toppings and a random location for a specific pizza.
    public Pizza(List<string> ingredientNames, List<string> unavailableIngredientNames, List<string> locationNames)
    {
        //System.Random rnd = new System.Random();
        for (int i = 0; i < numToppings; i++)
        {
            Debug.Log("pizza constructor");
            ingredients.Add(new Ingredient(ingredientNames, unavailableIngredientNames));
        }
        for (int i = 0; i < numToppings; i++) 
        {
            Debug.Log("dumb");
        }
        //location = possibleLocations[rnd.Next(5)];
        //size = possibleSizes[rnd.Next(2)];
    }

    

    public void toAudio()
    {
        
        foreach (Ingredient i in ingredients)
        {
            i.playAudio();
        }
        
    }
    public List<Ingredient> getIngredients()
    {
        return ingredients;
    }

    //returns all the ingredients listed in a string.
    public override string ToString()
    {
        string result = "";
        foreach (Ingredient i in ingredients)
        {
            result += i.getName();
        }
        return result;
    }



}
