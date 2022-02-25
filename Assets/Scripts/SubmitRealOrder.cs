using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitRealOrder : Interactable
{
    [SerializeField] private AudioClip goodSound;
    [SerializeField] private AudioClip badSound;
    private AudioSource audioSource;
    private Orders_Note orderScript;
    /*Precondition: the player must be named "Player"
     *              player must have the Orders_Note attached to it
     *Postcondition: plays a noice whether a real or fake pizza was submitted
     */
    protected override void interact()
    {
        orderScript = GameObject.Find("Player").GetComponent<Orders_Note>();
        audioSource = gameObject.GetComponent<AudioSource>();
        orderScript.submit();
        if (/*orderScript.curPizza.getReal()*/true)
        {
            audioSource.clip = goodSound;

        }
        else
        {
            audioSource.clip = badSound;
        }
        audioSource.Play();
    }
}
