using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : Customer
{
    //private static ArrayList allToppings = getIngredients();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private class Ingredient
    {
        ArrayList ingredients;
        string name;
        bool available;
        public Ingredient(string name, bool available)
        {
            this.name = name;
            this.available = true;
            
        }
    }
}
