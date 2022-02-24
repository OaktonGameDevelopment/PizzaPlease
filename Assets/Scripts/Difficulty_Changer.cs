using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyChanger : MonoBehaviour
{
    public LevelDifficulty curLevelDifficulty;
    // Start is called before the first frame update

    /*
     * Preconditions: t represents the number of toppings you want to add
     * l represents the number of locations you want to add
     */
    public void addDifficulty(int t, int l, int s)
    {
        addStuff(t, curLevelDifficulty.toppingsAvaliable, curLevelDifficulty.toppingsUnavaliable);
        addStuff(l, curLevelDifficulty.locationsAvaliable, curLevelDifficulty.locationsUnavaliable);
        addStuff(s, curLevelDifficulty.saucesAvaliable, curLevelDifficulty.saucesUnavalable);
    }
    /*
     * Preconditions: nums represents the number of stuff of type T that should be added to the game
     * Postcondition: adds nums # of stuff to the avaliable respective list
     * removes added stuff from unavalable respective list
     */
    private void addStuff<T>(int num, List<T> avaliable, List<T> unavaliable)
    {
        for(int i = 0; i<num; i++)
        {
            if (unavaliable.Count > 0)//makes sure there is stuff to add
            {
                int rand = Random.Range(0, unavaliable.Count - 1);//gets a random index of the relavent list
                avaliable.Add(unavaliable[rand]);//sets an unavaliable thing to be avaliable
                unavaliable.RemoveAt(rand);//remove the thing that was made avaliable
            }
        }
    }

}
