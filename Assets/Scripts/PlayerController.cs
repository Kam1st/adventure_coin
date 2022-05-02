using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator anim;

    [SerializeField]
    private float MovRight;

    [SerializeField]
    private float MovLeft;

    [SerializeField]
    private float MovJump;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(MovLeft, rb2d.velocity.y);
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            anim.Play("Run");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(MovRight, rb2d.velocity.y);
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            anim.Play("Run");
        }

        else
        {
            anim.Play("Idle");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, MovJump);
            anim.StopPlayback();
        }
    }


    

}
