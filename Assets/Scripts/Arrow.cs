using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject explosion;
    public Rigidbody2D arrowRb;
    public float arrowSp;


    private void Start()
    {
        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        Vector2 arrowDir = transform.position + transform.right * arrowSp * Time.deltaTime;
        arrowRb.MovePosition(arrowDir);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //destroi explosion criada
            GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(exp, 1f);

            //destroi inimigo -- tag
            Destroy(collision.gameObject);

            // destroi flecha
            Destroy(gameObject);
        }
    }

}
