using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimChar : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private float MainCharSpeed;

    /*[SerializeField]
    private float jumpForce = 20; */

    

    float velocity;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        float input_x = Input.GetAxisRaw("Horizontal");
        //var input_y = Input.GetAxisRaw("Vertical");

        bool walking = Mathf.Abs(input_x) > 0;

        animator.SetBool("is_walking", walking);

        if(walking)
        {
            animator.SetFloat("input_x", input_x);

            transform.Translate(new Vector3(input_x, 0, 0).normalized * Time.deltaTime * 2f * MainCharSpeed);
        }


    }
}
