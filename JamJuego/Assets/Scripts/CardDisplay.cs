using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image artworkImage;

    public TextMeshProUGUI costText;
    public TextMeshProUGUI damageText;

    void Start()
    {
        artworkImage.sprite = card.img;
        nameText.SetText(card.name);
        descriptionText.SetText(card.description);
        costText.text = card.cost.ToString();
        damageText.text = card.damage.ToString();
    }

}
