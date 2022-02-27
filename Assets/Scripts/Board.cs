using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Board : Interactable
{

    public GameObject popUpBox;
    
    [SerializeField] private LevelDifficulty a;

    

    protected override void interact()
    {
        PopUp();
    }

    public void PopUp()
    {
        popUpBox.SetActive(true);
        for(int i = 0; i < a.toppingsAvaliable.Count; i++)
        {
            GameObject.FindWithTag(a.toppingsAvaliable[i]).SetActive(true);
        }
        for(int i = 0; i < a.toppingsUnavaliable.Count; i++)
        {
            GameObject.FindWithTag(a.toppingsUnavaliable[i]).SetActive(false);
        }

    }

}
