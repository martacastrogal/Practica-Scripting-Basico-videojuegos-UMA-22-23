using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class OrcController : MonoBehaviour
{
    [Header("Orcs Health")]
    private float maxhealth;
    public float health;

    [Header("Orcs Movement")]
    public float moveSpeed; // Define la velocidad de movimiento y rotación editable en Unity

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

    }
    private void Awake()
    {
        maxhealth = health;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Blacksmith")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rotate"))
        {
            
            transform.Rotate(Vector3.up, 90);
        }
        if (other.CompareTag("Rotate-90"))
        {
            
            transform.Rotate(Vector3.up, -90);
        }
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            health--;
            if (health <= 0)
                Destroy(gameObject);
        }
    }
}
