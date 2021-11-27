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
    private string stringID;
    private Atributos atributos_player;
    private Atributos atributos_enemy;

    private void Start()
    {
        atributos_player = player.GetComponent<Atributos>();
        atributos_enemy = enemy.GetComponent<Atributos>();
    }

    public void UsarCarta(Card laCarta)
    {
        stringID = laCarta.name;
        int coste = laCarta.cost;
        int dmg = laCarta.damage;
        bool esUnaCura = laCarta.esSalud;
        bool esUnBloqueo = laCarta.esBloqueo;

        Debug.Log("Has usado: " + stringID);

        if (esUnaCura) { atributos_player.setHP(atributos_player.getHP() + dmg); }
        else if (esUnBloqueo) { atributos_player.updateShield(dmg); }
        else if (atributos_enemy.getHP() >= 0) {
            atributos_enemy.setHP(atributos_enemy.getHP() - dmg);
            atributos_player.setCoste(atributos_player.getCoste() - coste);
        }

        actualizarStats();

    }
 
    private void actualizarStats()
    {
        vidaEnemigo.text = atributos_enemy.getHP().ToString();
        vidaPlayer.text = atributos_player.getHP().ToString();
        escudoPlayer.text = atributos_player.getShield().ToString();
    }

}