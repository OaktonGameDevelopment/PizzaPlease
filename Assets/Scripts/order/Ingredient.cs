using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient
{
    protected string name;
    [SerializeField] protected AudioManager audioManager;
    bool real;

    public static List<string> possibleToppings;

    public Ingredient(List<string> ingredientNames, List<string> fakeNames)
    {
        /*
        */
        possibleToppings.AddRange(ingredientNames);
        possibleToppings.AddRange(fakeNames);
        int i = Random.Range(0, possibleToppings.Count);
        name = possibleToppings[i];
        possibleToppings.RemoveAt(i);
    }
    public List<string> getPossibleToppings()
    {
        return possibleToppings;
    }

    public void playAudio()
    {
        
        audioManager.Play("onions1");
    }

    public string getName()
    {
        return name;
    }

}
