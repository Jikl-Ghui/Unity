using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody ab;
    public float forward;
    public float side;
    public float up;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        //ab.AddForce(0, 10, forward);

        if (Input.GetKey("w"))
        {
            ab.AddForce(0, 0, forward);
        }
        if (Input.GetKey("s"))
        {
            ab.AddForce(0, 0, -forward);
        }
        if (Input.GetKey("a"))
        {
            ab.AddForce(-side, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            ab.AddForce(side, 0, 0);
        }
        
        if(ab.position.y<-1f)
        {
            FindFirstObjectByType<Restart>().GameOver();
        }

    }
}
