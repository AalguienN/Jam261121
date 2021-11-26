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
}
