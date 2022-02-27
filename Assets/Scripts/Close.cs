using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{

    public GameObject popUpBox;
    public GameObject popUpBox2;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && popUpBox.activeSelf)
        {
            print("is this happening");
            popUpBox.SetActive(false);
        }
        else if (Input.GetKeyDown("e") && popUpBox2.activeSelf)
        {
            print("is this happening");
            popUpBox2.SetActive(false);
        }


    }
}
