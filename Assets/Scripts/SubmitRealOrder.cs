using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitRealOrder : Interactable
{
    [SerializeField] private AudioClip goodSound;
    [SerializeField] private AudioClip badSound;
    private AudioSource audioSource;
    private Orders_Note orderScript;
    private GameObject canvas;
    /*Precondition: the player must be named "Player"
     *              player must have the Orders_Note attached to it
     *              there must be a UI Canvas in the scene called Canvas with the PerformanceLog Script on it
     *Postcondition: plays a noise whether a real or fake pizza was submitted
     */
    protected override void interact()
    {
        orderScript = GameObject.Find("Player").GetComponent<Orders_Note>();
        audioSource = gameObject.GetComponent<AudioSource>();
        canvas = GameObject.Find("Canvas");
        orderScript.submit();
        if (/*orderScript.curPizza.getReal()*/true)
        {
            audioSource.clip = goodSound;
            canvas.GetComponent<PerformanceLog>().submittedReal();
        }
        else
        {
            audioSource.clip = badSound;
            canvas.GetComponent<PerformanceLog>().submittedFake();
        }
        audioSource.Play();
    }
}
