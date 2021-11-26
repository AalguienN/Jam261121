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
        switch (stringID)
        {
            case "Guantazo":
                Guantazo();
                break;
            case "Punyetazo":
                Punyetazo();
                break;
            case "Bola de Fuego":
                BolaFuego();
                break;
            case "Bola de Hielo":
                BolaHielo();
                break;
           /* case "Guardia":
                Guardia();
                break;
            case "Contoneo":
                Contoneo();
                break;
            case "Cura":
                Cura();
                break;*/
        }
    }
    private void Guantazo()
    {
        if (atributos_enemy.getShield() <= 0)
        {
            atributos_enemy.setHP(atributos_enemy.getHP() - 1);
            atributos_player.setCoste(atributos_player.getCoste() - 1);
        }
        else
        {
            atributos_enemy.updateShield(atributos_enemy.getShield() - 1);
            atributos_player.setCoste(atributos_player.getCoste() - 1);
        }
    }
    private void Punyetazo()
    {
        if (atributos_enemy.getShield() <= 0)
        {
            atributos_enemy.setHP(atributos_enemy.getHP() - 3);
            atributos_player.setCoste(atributos_player.getCoste() - 2);
        }
        else
        {
            atributos_enemy.updateShield(atributos_enemy.getShield() - 3);
            atributos_player.setCoste(atributos_player.getCoste() - 2);
        }
    }
    private void BolaFuego()
    {
        if (atributos_enemy.getShield() <= 0)
        {
            atributos_enemy.setHP(atributos_enemy.getHP() - 10);
            atributos_player.setCoste(atributos_player.getCoste() - 5);
        }
        else
        {
            atributos_enemy.updateShield(atributos_enemy.getShield() - 10);
            atributos_player.setCoste(atributos_player.getCoste() - 5);
        }
    }
    private void BolaHielo()
    {
        if (atributos_enemy.getShield() <= 0)
        {
            atributos_enemy.setHP(atributos_enemy.getHP() - 10);
            atributos_player.setCoste(atributos_player.getCoste() - 5);
        }
        else
        {
            atributos_enemy.updateShield(atributos_enemy.getShield() - 10);
            atributos_player.setCoste(atributos_player.getCoste() - 5);
        }
    }
    /*private void Guardia()
    {
        atributos_enemy.;
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
    */

}