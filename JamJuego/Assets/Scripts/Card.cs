using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nueva Carta", menuName = "Carta")]
public class Card : ScriptableObject
{
    public Sprite img;
    public new string name;
    public string description;

    public int cost;
    public int damage;
    public int contador;        //Contador de cartas

    
    public List<Card> mazo = new List<Card>();     //Numero maximo de cartas disponible (20)
    public List<Card> mano = new List<Card>();     //Numero maximo de cartas que puede llevar el jugador (4)


    public void Cartas(List<Card> c) {
        
        contador = c.Count;
    
    }
}
