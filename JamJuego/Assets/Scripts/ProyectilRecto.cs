using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject player;
    public GameObject target;

    public float speed = 10f;

    public Vector3 movePosition;

    private Vector2 playerXY;
    private Vector2 targetXY;

    float nextX;
    float nextY;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        playerXY = new Vector2(player.transform.position.x, player.transform.position.y);
        targetXY = new Vector2(target.transform.position.x, target.transform.position.y);
        nextX = Mathf.MoveTowards(transform.position.x, targetXY.x, speed * Time.deltaTime);
        nextY = Mathf.MoveTowards(transform.position.y, targetXY.y, speed * Time.deltaTime);
        

        movePosition = new Vector2(nextX, nextY);
        transform.position = movePosition;

        if (movePosition == target.transform.position)
        {
            HacerDanyo(target);
        }
    }
}