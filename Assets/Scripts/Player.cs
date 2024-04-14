using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private Vector2 dir;

    private void Update()
    {
        dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {   
        // mover o persongagem sem problemas
        rb.MovePosition(rb.position + dir.normalized * speed * Time.deltaTime);
    }
}
