using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimChar : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private float MainCharSpeed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        var input_x = Input.GetAxisRaw("Horizontal");
        //var input_y = Input.GetAxisRaw("Vertical");

        if (input_x > 0)
        {
            animator.SetInteger("Direction", 1);
        }

        if (input_x < 0)
        {
            animator.SetInteger("Direction", 0);
        }

        transform.Translate(new Vector3(input_x,0, 0) * Time.deltaTime * MainCharSpeed);

        if (input_x == 0)
        {
            animator.speed = 0;
            
        }
        else 
        {
            animator.speed = 1;
        }
    }
}
