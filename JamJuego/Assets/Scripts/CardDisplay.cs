using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descriptionText;

    public Image artworkImage;
    public Text costText;
    public Text attackText;


    void Start()
    {/*
        nameText.text = card.name;
        descriptionText.text = card.description;
        artworkImage.sprite = card.img;
        costText = card.cost.ToString();
        attackText.text = card.damage.ToString();
  */  }

}
