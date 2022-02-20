using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour //Superclass for all interactable objects
{
    private RaycastHit objectHit;
    private Color originalColor;
    private RaycastHit lastObjectHit;
    void Start()
    {
    }
    
    void Update()
    {
        Debug.DrawRay(Camera.main.ScreenPointToRay(Input.mousePosition).origin, Camera.main.ScreenPointToRay(Input.mousePosition).direction * 10, Color.red, 1.0f);
        if (lastObjectHit.collider != null && (objectHit.collider != null || lastObjectHit.collider != objectHit.collider))
        {
            lastObjectHit.collider.GetComponent<MeshRenderer>().material.color = originalColor;
        }
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out objectHit) && objectHit.collider.GetComponentInParent<Interactable>() != null)
        {
            print("HIT");
            originalColor = objectHit.collider.GetComponent<MeshRenderer>().material.color;
            objectHit.collider.GetComponent<MeshRenderer>().material.color = Color.yellow;
            lastObjectHit = objectHit;
            if (Input.GetKeyDown("e"))
            {
                interact();
            }
        }
        else
            print("raycast didnt hit");

    }

    protected virtual void interact() { print("Interactable's interact() fuction was called instead"); }

}
