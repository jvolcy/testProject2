using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
//Assets
//Background: https://pngtree.com/freebackground/modern-double-color-futuristic-neon-background_1181573.html
 




public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0.05f * Vector3.forward);
        //transform.Rotate(0f, 0f, 0.1f);
        //transform.Translate(0.01f * (Vector3.right + Vector3.up));
        //if (transform.position.x < 6f)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.01f, 0f, 0f);
        }
    }
}
