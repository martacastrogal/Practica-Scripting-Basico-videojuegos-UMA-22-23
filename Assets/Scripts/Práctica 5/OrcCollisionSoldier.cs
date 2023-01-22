using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcCollisionSoldier : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Soldier")
        {
           collision.gameObject.SetActive(false);   
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Blacksmith")
        {
            Destroy(collision.gameObject);
        }
    }
}
