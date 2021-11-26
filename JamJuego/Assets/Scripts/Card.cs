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
}
