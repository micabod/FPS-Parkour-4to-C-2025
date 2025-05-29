using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccioncolciones : MonoBehaviour
{
   void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        Destroy(collision.gameObject);
    }
}

