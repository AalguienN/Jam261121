using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorDeMazmorra : MonoBehaviour
{
    [Header("Probabilidades")]
    //Tocar estos 3 parámetros para cambiar las probabilidades de los mapas;
    public int probSEnemigo = 50;
    public int probSCofre = 25;
    public int probSCuracion = 25;

    private int probTotales;

    public void Start()
    {
        probTotales = probSEnemigo + probSCofre + probSCuracion;
        NuevaSala();
    }
   
    public void NuevaSala() {
        int nAleatorio = Random.Range(0, probTotales);
        print (nAleatorio);
        if (nAleatorio < probSEnemigo)
        {
            //Load Enemigo
            print("Enemigo");
        }
        else if (nAleatorio < probSCofre + probSEnemigo)
        {
            //Load Cofre
            print("Cofre");
        }
        else
        {
            print("Curacion");
            //Load Curación
        }
    }
}
