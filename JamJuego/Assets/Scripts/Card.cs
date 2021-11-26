using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nueva Carta", menuName = "Carta")]
public class Card : ScriptableObject
{
    public Sprite imagen;
    public new string nombre;
    public string descripcion;

    public int coste;
    public int ataque;
    
    public Mazo[20];                //Mazo de cartas disponible (5 niveles para 4 tipos de carta)
    public Mano[4];                 //Numero máximo de cartas que puede llevar el jugador
    
    
    
}
