using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "CurrentLevelDifficulty", menuName = "LevelDifficulty", order = 1)]
public class LevelDifficulty : ScriptableObject //This class will hold the information about how the difficult of the level changes certain aspects
{//Please only make one of this scriptableObject
    public int maxNumCustomers;//the max number of customers allowed in the line
    public float customerDelay;//the time between each in person customer
    public float customerPatienceDecay;//the speed at which customers lost patience
    public float customerTolerenceLevel;//the amount of time the customers have until they start to lose patience
    public List<string> toppingsAvaliable;
    public List<string> toppingsUnavaliable;
    //add more here if you want
}
