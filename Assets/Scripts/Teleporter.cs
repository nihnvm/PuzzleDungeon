using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
   

    public int code;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
           
            foreach (Teleporter tp in FindObjectsOfType<Teleporter>()) {
                
                if (tp.code == code && tp != this) {
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    other.gameObject.transform.position = position;
                }
            }


        }
    }

}
