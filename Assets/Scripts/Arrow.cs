using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Arrow : MonoBehaviour
{
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

}
