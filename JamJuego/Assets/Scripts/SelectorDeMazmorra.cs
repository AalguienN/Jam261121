using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorDeMazmorra : MonoBehaviour
{
    [Header("Probabilidades")]
    //Tocar estos 3 parámetros para cambiar las probabilidades en los mapas
    public int probSEnemigo = 50;
    public int probSCofre = 25;
    public int probSCuracion = 25;

    [Header("Prefabs")]
    public GameObject[] enemigos;
    public GameObject cofre;
    private int probTotales;

    [Header("ObjetoCargado")]
    private GameObject objetoActivo;


    public void Start()
    {
        probTotales = probSEnemigo + probSCofre + probSCuracion;
        NuevaSala();
    }
   
    public void NuevaSala() {
        // 
        if (objetoActivo != null) {
            Destroy(objetoActivo);
        }
        
        int nAleatorio = Random.Range(0, probTotales);
        print (nAleatorio);
        if (nAleatorio < probSEnemigo)
        {
            //Load Enemigo
            objetoActivo = Instantiate(enemigos[Random.Range(0,enemigos.Length)], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            objetoActivo.name = "Enemigo";
            print("Enemigo");
        }
        else if (nAleatorio < probSCofre + probSEnemigo)
        {
            //Load Cofre
            objetoActivo = Instantiate(cofre, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            objetoActivo.name = "Cofre";
            print("Cofre");
        }
        else
        {
            // Load Curación
            print("Curacion");
            
        }
    }
}
