using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject objToSpawn; //objeto a instanciar
    public float spawnTime; //Tiempo entre instanciaciones
    public float radius;

    private void Start()
    {
        InvokeRepeating("SpawnObj", 0, spawnTime); //Llama al métoco "SpawnObj" pasado un tiempo y luego lo reptie cada ese mismo tiempo.

    }

    public void SpawnObj()
    {
        Vector2 pos = Random.insideUnitCircle.normalized * radius;
        Vector3 position = new Vector3(pos.x, 0, pos.y);
        Instantiate(objToSpawn, position, Quaternion.identity); //Crea el objeto en la posición y con la rotación que tenga el objeto que contiene el script
    }
    private void OnDrawGizmos()
    {
        Handles.DrawWireDisc(transform.position, Vector3.up, radius);
    }

}
