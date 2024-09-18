using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this function gets called when we collide with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if we collided with another object, we need to play a sound

        //Step 1: create an AudioSource variable
        AudioSource audioSource;

        //Step 2: associate our variable with our AudioSource
        audioSource = GetComponent<AudioSource>();

        //Step 3: access our AudioSource
        audioSource.Play();

    }
}
