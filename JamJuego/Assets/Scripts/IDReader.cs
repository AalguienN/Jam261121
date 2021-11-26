using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IDReader : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI vidaPlayer;
    [SerializeField] private TextMeshProUGUI escudoPlayer;
    [SerializeField] private TextMeshProUGUI vidaEnemigo;


    public GameObject player;
    public GameObject enemy;
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
            case "Puñetazo":
                Punyetazo();
                break;
            case "Bola de Fuego":
                BolaFuego();
                break;
            case "Bola de Hielo":
                BolaHielo();
                break;
           case "Guardia":
                Guardia();
                break;
            case "Contoneo":
                Contoneo();
                break;
            case "Cura":
                Cura();
                break;
        }
    }
    private void Guantazo()
    {
        Debug.Log("Usando guantazo");
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
        actualizarStats();
    }
    private void Punyetazo()
    {
        Debug.Log("Usando puñetazo");
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
        actualizarStats();
    }
    private void BolaFuego()
    {
        Debug.Log("Usando bolafuego");
        Debug.Log(atributos_enemy.getHP());
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
        actualizarStats();
    }
    private void BolaHielo()
    {
        Debug.Log("Usando bolahielo");
        Debug.Log(atributos_enemy.getHP());
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
        Debug.Log(atributos_enemy.getHP());
        actualizarStats();
    }
    private void Guardia()
    {
        Debug.Log("Usando guardia");
        Debug.Log(atributos_player.getShield());
        atributos_player.updateShield(atributos_player.getShield() + 1);
        atributos_player.setCoste(atributos_player.getCoste() - 1);
        Debug.Log(atributos_player.getShield());
        actualizarStats();
    }
    private void Contoneo()
    {
        Debug.Log("Usando contoneo");
        Debug.Log(atributos_player.getShield());
        atributos_player.updateShield(atributos_player.getShield() + 6);
        atributos_player.setCoste(atributos_player.getCoste() - 3);
        Debug.Log(atributos_player.getShield());
        actualizarStats();
    }
    private void Cura()
    {
        Debug.Log("Usando cura");
        Debug.Log(atributos_player.getHP());
        atributos_player.setHP(atributos_player.getHP() + 4); 
        atributos_player.setCoste(atributos_player.getCoste() - 2);
        Debug.Log(atributos_player.getHP());
        actualizarStats();
    }

    private void actualizarStats()
    {
        vidaEnemigo.text = atributos_enemy.getHP().ToString();
        vidaPlayer.text = atributos_player.getHP().ToString();
        escudoPlayer.text = atributos_player.getShield().ToString();
    }


}