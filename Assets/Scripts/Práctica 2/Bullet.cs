using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocity;
    public float timeBulletActive;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, timeBulletActive);
        transform.Translate(velocity*Time.deltaTime*Vector3.forward);
    }
   

}
