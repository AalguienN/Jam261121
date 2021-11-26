using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public static bool pasar;
    private BoxCollider2D box;
    public GameObject Personaje;
    public GameObject Posicion;
    public Vector3 VectPos;
    public bool combate;
    private GameObject enemigo;


    void Start() 
    {
        VectPos = Posicion.transform.position;
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && combate == false)
        {
            Personaje.transform.position = VectPos;
            box = Posicion.GetComponent<BoxCollider2D>();
            box.enabled = false;
            pasar = true;
        }
    }

    void Update()
    {
        enemigo = GameObject.FindWithTag("Enemigo");
        if (enemigo != null)
        {
            combate = true;
        }
        else 
        { 
            combate = false;
        }
    }
}
