using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Restart gameManager;

    private void OnTriggerEnter()
    {
        gameManager.Complete();
    }
}
