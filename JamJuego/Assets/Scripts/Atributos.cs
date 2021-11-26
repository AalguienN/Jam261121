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
    public float coste;       //coste

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

    public void updateHP(float x) {
        if (hp > 0) {
            hp += x;
            vidaPersonaje.text = hp.ToString();
        } 
        //Si hp <= 0 el personaje muere
        else Destroy(this.gameObject);
    }

    public void updateShield(int x) {
        shield += x; 
    }

    public int getShield() { return shield; }

    //Cuando muere el personaje se llama esta funci�n (siempre que se destruye el objeto)

    //private void OnDestroy()
    /*
    {
        LoadScene("Menu");
    }
    */
}