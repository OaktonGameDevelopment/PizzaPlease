using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMap : Interactable
{
    public GameObject popUpBox;
    [SerializeField] private LevelDifficulty a;


    protected override void interact()
    {
        Debug.Log(popUpBox);
        print("is this happening?");
        PopUp();
    }

    public void PopUp()
    {
        popUpBox.SetActive(true);


    }

}
