using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient
{
    protected string name;
    [SerializeField] protected AudioManager audioManager;
    bool real;
    private static List<string> possibleToppings = new List<string>{ "mushrooms", "pepperoni", "bellPeppers", "pineapple", "olives", "onions" };

    public Ingredient()
    {
        int i = Random.Range(0, possibleToppings.Count);
        name = possibleToppings[i];
        possibleToppings.RemoveAt(i);
    }
    public ArrayList getPossibleToppings()
    {
        //return possibleToppings;
    }

    public void playAudio()
    {
        audioManager.Play("onions1");
    }

}
