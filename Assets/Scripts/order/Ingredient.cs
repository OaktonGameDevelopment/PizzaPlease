using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ingredient : MonoBehaviour
{
    string name;
    bool real;
    private string[] possibleToppings = { "Mushrooms", "Anchovies", "Pepperoni", "Bell Peppers", "Pineapple", "Olives", "Onions" };

    public string[] getPossibleToppings()
    {
        return possibleToppings;
    }
    // Start is called before the first frame update

}
