using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderSumonArea : MonoBehaviour
{
    public bool colision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //Salida del player de la plataforma
        {

            colision = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player")) //Colisión del player con la plataforma
        {

            colision = false;

        }
    }

}
