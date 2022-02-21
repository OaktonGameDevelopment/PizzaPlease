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

    public override void playAudio()
    {
        FindObjectOfType<AudioManager>().Play("onions" + Random.Range(1f, 1f));
    }
}
