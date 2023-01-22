using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerCannon : MonoBehaviour
{
    [Header("Bullets instantiate")]
    public Transform posInstanciar;
    public GameObject bulletsPrefab;
    public List<GameObject> bulletList;
    public int numBullets;
    private Transform posOrc;
    public float coolDown = 1f;
    private float timeCounter;


    
    private void Awake()
    {
        timeCounter = 0;
        bulletList = new List<GameObject>();  
    }

    private void Update()
    {
        
        transform.LookAt(posOrc);
        timeCounter += Time.deltaTime;
        if(timeCounter >=coolDown && posOrc!=null)
        {
            shoot();
            timeCounter= 0;
        }      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            transform.LookAt(other.transform);

            posOrc= other.transform;
        }
    }
    
    private void shoot()
    {
        GameObject bulletShoot= Instantiate(bulletsPrefab);
        bulletShoot.transform.rotation = transform.rotation;
        bulletShoot.transform.position = posInstanciar.transform.position;
    }
}
