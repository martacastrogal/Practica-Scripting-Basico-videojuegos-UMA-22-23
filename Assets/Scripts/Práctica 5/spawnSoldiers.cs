using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnSoldiers : MonoBehaviour
{


    public float radioColisionSoldiers;
    public List<GameObject> soldiers;
    private bool spawn;
    public float radioMinSpawn;
    public float radioMaxSpawn;
    public GameObject soldierPrefab;
    public int numMaxSoldiers;
    private void soldiersSpawn()
    {
        Vector3 pos = Random.insideUnitCircle.normalized * Random.Range(radioMinSpawn, radioMaxSpawn);
        pos.z = pos.y;
        pos.y = 0;
        if (!checkSoldierCollision(pos))
        {
            GameObject soldier = getFreeObject();
            soldier.transform.position = pos;
            soldier.transform.LookAt(gameObject.transform);
            soldier.transform.Rotate(new Vector3(0f, 180f, 0f));
            soldier.SetActive(true);
        }
    }

    private void Awake()
    {
        soldiers = new List<GameObject>();
        for (int i = 0; i < numMaxSoldiers; i++) 
        {
           GameObject g= Instantiate(soldierPrefab); 
            g.SetActive(false);
            soldiers.Add(g); 
        }
    }
    private void Update()
    {
        if(spawn)
            soldiersSpawn();
        
    }
    bool checkSoldierCollision(Vector3 pos)
    {
  
        for(int i=0; i<soldiers.Count; i++)
        {
            if(Vector3.Distance(pos, soldiers[i].transform.position)< radioColisionSoldiers)
            {
                return true;
                
            }
        }

        return false;
    }
    private void OnMouseDown()
    {
        spawn = true;
    }
    private void OnMouseUp()
    {
       new WaitForSeconds(1);
        spawn = false;
    }

    GameObject getFreeObject()
    {
        return soldiers.Find(item => item.activeInHierarchy == false);
    }


}
