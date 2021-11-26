using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDReader : MonoBehaviour
{
    public GameObject bolaFuego;
    public GameObject bolaHielo;
    public GameObject guardia;
    public GameObject contoneo;
    public GameObject cura;
    public GameObject clon;
    public GameObject parentAtaques;

    public GameObject player;
    public GameObject enemy;
    public GameObject Puntos_Accion;
    /*private float vida_enemy;
    private float vida_player;
    private float pa;
    private float escudo_player;
    private float escudo_enemy;*/
    private string stringID;
    private Atributos atributos_player;
    private Atributos atributos_enemy;



    private void Start()
    {
        /*vida_player = player.GetComponent<Atributos>()
        vida_enemy =  enemy.GetComponent<Atributos>()
        pa = Puntos_Accion.GetComponent<Atributos>()
        escudo_player = player.GetComponent<Atributos>()
        escudo_enemy = enemy.GetComponent<Atributos>().getShield();*/
        atributos_player = player.GetComponent<Atributos>();
        atributos_enemy = enemy.GetComponent<Atributos>();
    }

    // Update is called once per frame
    public void UsarCarta(GameObject laCarta)
    {
        stringID = laCarta.name;
        switch (stringID) {
            case "Guantazo" :
                Guantazo();
                break;
            case "Punyetazo" :
                Punyetazo();
                break; 
            case "Bola de Fuego" :
                BolaFuego();
                break; 
            case "Bola de Hielo" :
                BolaHielo();
                break; 
            case "Guardia" :
                Guardia();
                break; 
            case "Contoneo" :
                Contoneo();
                break; 
            case "Cura" :
                Cura();
                break; 
        }
    }
    private void Guantazo()
    {
        if (atributos_enemy.getShield() <= 0)
        {
            atributos_enemy.updateHP(atributos_enemy.getHP()--);
            atributos_player.coste--;
        }
        else
        {
            atributos_enemy.getShield()--;
            atributos_enemy.coste--;
        }
    }
    private void Punyetazo ()
    {
        if (atributos_enemy.getShield() <= 0)
        {
            = vida_enemy - 3;
            pa = pa - 2;
        }
        else
        {
            escudo_enemy = escudo_enemy - 3;
            pa = pa - 2;
        }
    }
    private void BolaFuego()
    {
        if (escudo_enemy <= 0)
        {
            vida_enemy = vida_enemy - 10;
            pa = pa - 5;
        }
        else
        {
            escudo_enemy = escudo_enemy - 10;
            pa = pa - 5;
        }
    }
    private void BolaHielo()
    {
        if (escudo_enemy <= 0)
        {
            vida_enemy = vida_enemy - 10;
            pa = pa - 5;
        }
        else
        {
            escudo_enemy = escudo_enemy - 10;
            pa = pa - 5;
        }
    }
    private void Guardia() {
        escudo_player++;
        pa--;
    }
    private void Contoneo()
    {
        escudo_player = escudo_player + 6;
        pa = pa - 3;
    }
    private void Cura()
    {
        vida_player = vida_player + 4;
        pa = pa - 2;
    }


}
