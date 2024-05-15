using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraLoc;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + cameraLoc;
    }
}
