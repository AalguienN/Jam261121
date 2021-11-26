using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayHandler : MonoBehaviour
{
    private int mazo_length = 20;
    private int mano_length = 4;
    public GameObject[] mazo;
    public GameObject[] mano;
    public GameObject[] mano2;
    private int indice_mazo = 0;

    public void Start() {
        mazo = new GameObject[mazo_length];
        mano = new GameObject[mano_length];
        mano2 = new GameObject[mazo_length];
    }
    private void Update()
    {
        ColocarCartas();
        if (Input.GetKeyDown("Q") == true) {
            ActualizarMano(1);

        }
        if (Input.GetKeyDown("W") == true)
        {
            ActualizarMano(2);

        }
        if (Input.GetKeyDown("E") == true)
        {
            ActualizarMano(3);

        }
        if (Input.GetKeyDown("R") == true)
        {
            ActualizarMano(4);

        }
    }

    public void ActualizarMano(int numCartaUsada)
    {
        transform.gameObject.GetComponent<IDReader>().UsarCarta(mano[numCartaUsada]);
        mano[numCartaUsada] = mazo[indice_mazo % 20];
        indice_mazo++;
    }

    public void ColocarCartas()
    {
        for(int i = 0; i < mano_length; i++)
        {
            mano[i].transform.position = mano2[i].transform.position;
        }
    }
}
