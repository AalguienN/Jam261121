using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Atributos : MonoBehaviour
{
    [Header("Vida")]
    public float maxHP = 100;
    [SerializeField] private float hp;
    [SerializeField] private TextMeshProUGUI vidaPersonaje;
    [SerializeField] private int shield;
    [SerializeField] private TextMeshProUGUI escudoPersonaje;


    

    [Header("Otros Stats")]
    //Poner aqu� otros atributos como puede ser ataque, coste....
    //Actualmente no sirven para nada
    public float atk;       //Ataque
    public float coste;       //Coste

    private void Start()
    {
        shield = 0;
        hp = maxHP;
    }

    //La vida solo es accesible mediante funciones para controlar cuando se modifica
    //Modifica la vida del personaje
    public void setHP(float x) {
        hp = x;
    }
    //Devuelve la vida
    public float getHP() {
        return hp;
    }

    public float getCoste()
    {
        return coste;
    }

    public void setCoste(float x)
    {
        if (coste > 0) coste += x;
    }
    //Cuando muere el personaje se llama esta funci�n (siempre que se destruye el objeto)

    //private void OnDestroy()
    /*
    {
        LoadScene("Menu");
    }
    */
}