using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Atributos : MonoBehaviour
{
    [Header("Vida")]
    public float maxHP = 100;
    [SerializeField]
    private float hp;

    
    [Header("Otros Stats")]
    //Poner aquí otros atributos como puede ser ataque, coste....
    //Actualmente no sirven para nada
    public float atk;       //Ataque
    public float coste;       //Velocidad

    private void Start()
    {
        hp = maxHP;
    }

    //La vida solo es accesible mediante funciones para controlar cuando se modifica
    //Modifica la vida del personaje
    public void setHP(float x) {
        if (hp > 0) hp += x;
        //Si hp <= 0 el personaje muere
        else Destroy(this.gameObject);
    }
    //Devuelve la vida
    public float getHP() {
        return hp;
    }

    //Cuando muere el personaje se llama esta función (siempre que se destruye el objeto)

    /*private void OnDestroy()
    {
        LoadScene("Menu");
    }*/
}