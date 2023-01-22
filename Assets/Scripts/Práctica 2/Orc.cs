using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour
{
    public Transform posPlayer; 
    public float moveSpeed, rotationSpeed; // Define la velocidad de movimiento y rotación editable en Unity
   
    void Update() 
    { 
        transform.LookAt(posPlayer);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); 
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }      
    }
}
