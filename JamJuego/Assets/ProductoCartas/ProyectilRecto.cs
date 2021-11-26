using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilRecto : MonoBehaviour
{
    public GameObject player;
    public GameObject target;

    public float speed = 10f;

    public Vector2 movePosition;
    public Vector2 playerPosition;
    public Vector2 enemyPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
