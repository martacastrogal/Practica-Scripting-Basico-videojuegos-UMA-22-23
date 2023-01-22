using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class towerBases : MonoBehaviour
{
    public GameObject canon;

    private void OnMouseDown()
    {
        canon.SetActive(true);
        gameObject.SetActive(false);
    }
    
}
