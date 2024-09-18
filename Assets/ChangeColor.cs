using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Step 1: create a variable of type SpriteRenderer
        SpriteRenderer sr;

        //Step 2: assciate our variable with the matching component in the game object
        sr = GetComponent<SpriteRenderer>();

        //Step 3: access my SpriteRenderer
        sr.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
