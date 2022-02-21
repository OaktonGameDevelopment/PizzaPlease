using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("startorder" + Random.Range(1f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
