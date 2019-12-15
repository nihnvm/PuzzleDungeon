using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hello: " + gameObject.name);
            isFalling = true;
        
        }
    }

    private void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);

        }
    }


}



