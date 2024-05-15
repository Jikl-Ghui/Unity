using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Script1 movement;
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
       
        if (collision.collider.tag=="OtherObj")
        {
            Debug.Log("We hit an obstacle");
            FindAnyObjectByType<Restart>().GameOver();
            // movement.enabled=false;
        }
    }
}
