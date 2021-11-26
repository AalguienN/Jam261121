using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    // Gestionar la velocidad
    public float speed;

    //Guardar punto de destino
    Vector3 target;

    void Start() {
        //inicialmente el punto de destino es la posici�n actual
        target = transform.position;
    }

    void Update()
    {

        //Se detecta cuando hacemos clic izquierdo
        if (Input.GetMouseButton(0))
        {
            //buscamos la posici�n del clic respecto la escena
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Establecemos la z a 0 para que no se modifique la profundidad
            target.z = 0f;
        }

        //Movemos el objeto hacia el punto de destino a una velocidad rectificada
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //Opticamente podemos debugear una l�nea con el trayecto a recorer
        Debug.DrawLine(transform.position, target, Color.green);

    }
}