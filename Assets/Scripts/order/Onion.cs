using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : Ingredient
{
    public static bool real;
    public Onion()
    {
        name = getPossibleToppings()[6];
    }
}
