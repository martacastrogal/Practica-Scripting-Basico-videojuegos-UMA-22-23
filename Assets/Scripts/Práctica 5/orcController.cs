using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orcController : MonoBehaviour
{
    public int speedOrc;
    public GameObject blacksmith;

    private int speed;
    private Rigidbody rb; 

    private void Awake()
    {
        speed = speedOrc;
        transform.LookAt(blacksmith.transform);
    }

    private void Update()
    {
        gameObject.transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }



}
