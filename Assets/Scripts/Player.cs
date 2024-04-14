using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public SpriteRenderer sR;

    public Animator anim;

    private Vector2 dir;

    [Header("Arrow attack")]
    public Arrow arrow;
    public float fireRate;

    private float timeCount;

    private void Update()
    {   
        //mover persongagem com teclas horizontais e verticais
        dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        timeCount += Time.deltaTime;

        if(timeCount > fireRate)
        {
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            Quaternion rotation = Quaternion.Euler(0,0,angle);

            Instantiate(arrow, transform.position, rotation);

            timeCount = 0;
        }

        if(dir.x > 0)
        {   
            sR.flipX = false;
        }
        if(dir.x < 0)
        {
            sR.flipX = true;
        }

        // identifica se ao presionar, for maior q 0
        if(dir.sqrMagnitude > 0)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false  );
        }


    }

    private void FixedUpdate()
    {   
        // mover o persongagem sem problemas
        rb.MovePosition(rb.position + dir.normalized * speed * Time.deltaTime);
    }
}
