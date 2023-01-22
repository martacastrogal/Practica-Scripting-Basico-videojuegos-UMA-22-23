using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public float rotationSpeed;//modificable en el inspector: 60
    public KeyCode rotateLeft, rotateRight;

    public Transform bulletStart;
    public GameObject bulletPrefab;
    public float bulletVelocity; //modificable en el inspector: 40
    public float bulletForce; //modificable en el inspector: 40

    public float time; //Modificable en inspector. Disparar cada 1 sg. 
    private float timer;

    private void Start()
    {
        timer = time;
    }

    void Update()
    {
        if (Input.GetKey(rotateLeft)) //Configurable en Unity: Tecla A
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);

        if (Input.GetKey(rotateRight)) //Configurable en Unity: Tecla D */
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        }
        if (Input.GetMouseButton(0))
        {
            if (timer <= 0)
            {
                GameObject BalaTemporal = Instantiate(bulletPrefab, bulletStart.transform.position, bulletStart.transform.rotation);
                timer = time;

            }
            else
            {
                timer -= Time.deltaTime;
            }

        }

    }

}
