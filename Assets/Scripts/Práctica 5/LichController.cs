using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichController : MonoBehaviour
{
    public float minDistance;
    public float maxDistance;
    public int maxOrc;
    public GameObject prefab;
    private void Start()
    {
        StartCoroutine(destroyLich());
    }

    void spawn()
    {
        for (int i = 0; i < maxOrc; i++)
        {
            Vector3 pos = Random.insideUnitCircle.normalized * Random.Range(minDistance, maxDistance) ;
            pos.z = pos.y; 
            pos.y = 0;
            GameObject orco = Instantiate(prefab, pos, Quaternion.Euler(0f,0f,0f));
        }
    }

    IEnumerator destroyLich()
    {
        yield return new WaitForSeconds(2);
        spawn();
        gameObject.SetActive(false);


    }
}
