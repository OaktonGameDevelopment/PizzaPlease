using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour //Superclass for all interactable objects
{
    private RaycastHit objectHit;//the RaycastHit info of the current 
    private Color originalColor;//stores the original color of the objectHit
    private RaycastHit lastObjectHit;//Stores the RaycastHit info last object hit
    void Update()
    {
        //This first line is for debugging where the direction ray will land
        //Debug.DrawRay(Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)).origin, Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)).direction * 10, Color.red, 1.0f);

        if (lastObjectHit.collider != null && (objectHit.collider != null || lastObjectHit.collider != objectHit.collider))//if lastObject hit is initialized and the current object hit is hitting a different object or isnt hitting anything
        {
            lastObjectHit.collider.GetComponent<MeshRenderer>().material.color = originalColor;//revert the yellow color of the lastObjectHit
        }
        if (Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)), out objectHit) && objectHit.collider.GetComponentInParent<Interactable>() == GetComponentInParent<Interactable>())//if the center of the screen is on a interactable object(an object with a script inherited from Interactable)
        {
            originalColor = objectHit.collider.GetComponent<MeshRenderer>().material.color;
            objectHit.collider.GetComponent<MeshRenderer>().material.color = Color.yellow;//change the color of the current interactable object to yellow
            lastObjectHit = objectHit;
            if (Input.GetKeyDown("e"))
            {
                interact();//calls the overrided interact method in the subclass
            }
        }
    }
    protected virtual void interact() { print("Interactable's interact() fuction was called instead"); }
}