using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objToSpawn; //objeto a instanciar
    public float spawnTime; //Tiempo entre instanciaciones

    private void Start()
    {
        InvokeRepeating("SpawnOrc", spawnTime, spawnTime); //Llama al m�todo "SpawnOrc" pasado un tiempo y luego lo reptie cada ese mismo tiempo.

    }

    public void SpawnOrc()
    {
        Instantiate(objToSpawn, transform.position, transform.rotation); //Crea el objeto en la posici�n y con la rotaci�n que tenga el objeto que contiene el script
    }
}
