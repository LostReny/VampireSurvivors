using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    GameObject player;
    public float speed;

    public Rigidbody2D enemyRb;
    public SpriteRenderer enemySr;
    private Vector2 enemyDir;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        // movendo a sprite do inimigo
        enemyDir = player.transform.position - transform.position;

        if (enemyDir.x > 0)
        {
            enemySr.flipX = false;
        }
        if (enemyDir.x < 0)
        {
            enemySr.flipX = true;
        }

        MoveTowards();
    }

    public void MoveTowards()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
