using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lich : MonoBehaviour
{
    public float moveSpeed; 
    public float rotationSpeed; 
    public KeyCode moveFront, moveBack, rotateLeft, rotateRight;

    bool colision;

    public float max;
    
    
    public Transform posInstanciar;
    public GameObject orcoPrefab;
    public List<GameObject> orcoLista;
    public int numOrcos;

    
    
    void Update()
    {
        if (Input.GetKey(moveFront)) //Configurable en Unity: Tecla W velocidad 5
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); 

        if (Input.GetKey(moveBack)) //Configurable en Unity: Tecla S velocidad 5
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime); 

        if (Input.GetKey(rotateLeft)) //Configurable en Unity: Tecla A velocidad 50
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime); 

        if (Input.GetKey(rotateRight)) //Configurable en Unity: Tecla D velocidad 50
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        
        
        if (Input.GetButtonDown("Jump"))
            invocarOrco();
        
    }
    private void Awake()
    {
        colision = false;  
        orcoLista= new List<GameObject>();
        GameObject orcoPrefabAux;
        
        for (int i = 0; i < numOrcos; i++)
        {
            orcoPrefabAux = Instantiate(orcoPrefab, transform.position, Quaternion.identity);
            orcoPrefabAux.SetActive(false);
            orcoLista.Add(orcoPrefabAux);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Summon Area"))
        {
            colision = other.GetComponent<colliderSumonArea>().colision;
            
        }
    }


    public void invocarOrco()
    {
        
        if (colision == true)
        {
            Debug.Log("Hola1");
            float distancia = Random.Range(3, max);
            GameObject newOrc = GetFreeObject();
            newOrc.transform.position = transform.position + (transform.forward * distancia);
            newOrc.transform.LookAt(gameObject.transform);
            newOrc.SetActive(true);
        }
    }
    public GameObject GetFreeObject() 
    {
        return orcoLista.Find(orcoPrefab => orcoPrefab.activeInHierarchy==false);   
    }
}



