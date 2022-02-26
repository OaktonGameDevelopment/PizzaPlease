using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitFakeOrder : Interactable
{
    [SerializeField] private AudioClip goodSound;
    [SerializeField] private AudioClip badSound;
    private AudioSource audioSource;
    private Orders_Note orderScript;
    /*Precondition: the player must be named "Player"
    *              player must have the Orders_Note attached to it
    *Postcondition: plays a noise whether a real or fake pizza was submitted
    */
    protected override void interact()
    {
        orderScript = GameObject.Find("Player").GetComponent<Orders_Note>();
        audioSource = gameObject.GetComponent<AudioSource>();
        orderScript.submit();
        if (/*orderScript.curPizza.getReal()*/true)
        {
            audioSource.clip = badSound;
            
        }
        else
        {
            audioSource.clip = goodSound;
        }
        audioSource.Play();
    }
}
