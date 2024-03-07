using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabiar_posicion : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
         if (other.transform != null)
        {
            
            other.transform.position = new Vector3(-0.913f, 0.127f, -0.4534f);
        }
    }
}
