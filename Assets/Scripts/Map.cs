using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Map :Interactable
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
        for (int i = 0; i < a.locationsAvaliable.Count; i++)
        {
            GameObject.FindWithTag(a.locationsAvaliable[i]).SetActive(true);
        }
        for (int i = 0; i < a.locationsUnavaliable.Count; i++)
        {
            GameObject.FindWithTag(a.locationsUnavaliable[i]).SetActive(false);
        }

    }
}
