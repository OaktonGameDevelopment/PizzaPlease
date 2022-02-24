using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyChanger : MonoBehaviour
{
    public LevelDifficulty curLevelDifficulty;
    // Start is called before the first frame update
    public void addDifficulty()
    {
    }
    /*
     * Preconditions: nums represents the number of toppings that should be added to the game
     * Postcondition: adds nums # different toppings to the avaliable toppings
     * removes added toppings from unavalable toppings
     */
    private void addToppings(int num)
    {
        for(int i = 0; i<num; i++)
        {
            int rand = Random.Range(0, curLevelDifficulty.toppingsUnavaliable.Count - 1);
            curLevelDifficulty.toppingsAvaliable.Add(curLevelDifficulty.toppingsUnavaliable[rand]);
            curLevelDifficulty.toppingsUnavaliable.RemoveAt(rand);
        }
    }
    /*
    * Preconditions: nums represents the number of toppings that should be added to the game
    * Postcondition: adds nums # different toppings to the avaliable toppings
    * removes added toppings from unavalable toppings
    */
    private void addLocations(int num)
    {
        for (int i = 0; i < num; i++)
        {
            int rand = Random.Range(0, curLevelDifficulty.locationsUnavaliable.Count - 1);
            curLevelDifficulty.locationsAvaliable.Add(curLevelDifficulty.locationsUnavaliable[rand]);
            curLevelDifficulty.locationsUnavaliable.RemoveAt(rand);
        }
    }
}
