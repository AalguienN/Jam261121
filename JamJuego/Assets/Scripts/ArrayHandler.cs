using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayHandler : MonoBehaviour
{
    public GameObject cartaBP;
    public GameObject[] tiposDeCarta;
    private int mazo_length = 20;
    private int mano_length = 4;
    public GameObject[] mazo;
    public GameObject[] mano;
    public GameObject[] mano2;
    private int indice_mazo;

    public void Start() {
        //mazo = new GameObject[mazo_length];
        mano = new GameObject[mano_length];
       // mano2 = new GameObject[mano_length];*/
        indice_mazo = 0;
        for (int i = 0; i < mazo_length; i++)
        {
             mazo[i] = tiposDeCarta[Random.Range(0, tiposDeCarta.Length)];
        }
        for (int j = 0; j < mano_length; j++)
        {
            ActualizarMano(j);
        }
        ColocarCartas();

    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q) == true) {
            this.gameObject.GetComponent<IDReader>().UsarCarta(mano[0]);
            ActualizarMano(0);
            ColocarCartas();

        }
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            this.gameObject.GetComponent<IDReader>().UsarCarta(mano[1]);
            ActualizarMano(1);
            ColocarCartas();

        }
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            this.gameObject.GetComponent<IDReader>().UsarCarta(mano[2]);
            ActualizarMano(2);
            ColocarCartas();

        }
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            this.gameObject.GetComponent<IDReader>().UsarCarta(mano[3]);
            ActualizarMano(3);
            ColocarCartas();

        }
    }

    public void ActualizarMano(int numCartaUsada)
    {
        mano[numCartaUsada] = mazo[indice_mazo];
        indice_mazo++;
    }
    
    public void ColocarCartas()
    {
        for(int i = 0; i < mano_length; i++)
        {
            GameObject cartaColocar = Instantiate(mano[i], new Vector3(0, 0, 0),
                Quaternion.identity) as GameObject;
            cartaColocar.transform.SetParent(mano2[i].transform, false);
            cartaColocar.transform.localScale = new Vector3(1,1,1);
        }
    }
    
}
