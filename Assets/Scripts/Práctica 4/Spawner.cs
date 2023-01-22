using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objToSpawn; //objeto a instanciar
    public float spawnTime; //Tiempo entre instanciaciones

    private void Start()
    {
        InvokeRepeating("SpawnOrc", spawnTime, spawnTime); //Llama al método "SpawnOrc" pasado un tiempo y luego lo reptie cada ese mismo tiempo.

    }

    public void SpawnOrc()
    {
        Instantiate(objToSpawn, transform.position, transform.rotation); //Crea el objeto en la posición y con la rotación que tenga el objeto que contiene el script
    }
}
