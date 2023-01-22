using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{
    [Header("Raycast detection")]
    public float distance;
    public LayerMask mask;
    private RaycastHit hit;
    Ray rayo;
    public Transform origenRayo;

    [Header("Soldier Movement")]
    public float speed;
    public float rotationSpeed;
    
    private void Start()
    {
        rayo.origin = origenRayo.position;
        rayo.direction = origenRayo.forward;
    }
    void Update()
    {
        rayo.origin = origenRayo.position;
        rayo.direction = origenRayo.forward;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        pruebaRaycast();   
    } 
    void pruebaRaycast()
    {

        if (Physics.Raycast(rayo, out hit, distance, mask))
        {
            if(hit.transform.gameObject.CompareTag("Blacksmith"))
                speed = 0;
            else
                transform.Rotate(Vector3.up, 90);
        }
        Debug.DrawRay(origenRayo.position, origenRayo.forward * distance, Color.yellow);

    }
    private void Awake()
    {
       
        rayo.origin= origenRayo.position;
        rayo.direction = origenRayo.forward;    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RocksGround"))
            speed /= 2;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("RocksGround"))
            speed *= 2;
    }


}

