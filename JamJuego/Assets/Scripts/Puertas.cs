using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    //[header("puerta abierta")]
    //public static bool pasar;
    [Header("Collider")]
    private BoxCollider2D box;
    [Header("Referencias a objectos")]
    public GameObject Personaje;
    public GameObject Posicion;
    public GameObject[] todasPuertas;
    //Posicion del personaje
    private Vector3 VectPos;

    //Existe enemigo
    public bool combate;

    [Header("Graficos")]
    public GameObject puertaGraf;
    


    void Start() 
    {
        VectPos = Posicion.transform.position;
        box = this.GetComponent<BoxCollider2D>();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && GameObject.FindWithTag("Enemigo") == null && Personaje.GetComponent<MovePlayer>().ultPuerta != this.gameObject)
        {
            Personaje.GetComponent<MovePlayer>().ultPuerta = Posicion.gameObject;

            //Llamamos al resto de puertas para que se acutalicen 
            foreach (GameObject puerta in todasPuertas) {
                puerta.GetComponent<Puertas>().ActualizarPuerta();
            }
            Personaje.transform.position = VectPos;
        }
        
    }

    // Cuando "cambiamos" de sala se llama a esta función a cada puerta
    public void ActualizarPuerta() {
        
        if (this.gameObject == Personaje.GetComponent<MovePlayer>().ultPuerta)
        {
            this.puertaGraf.SetActive(true);
            box.enabled = false;
        }
        else
        {
            this.puertaGraf.SetActive(false);
            box.enabled = true;
        }
    }

}
