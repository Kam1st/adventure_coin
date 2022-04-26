using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCharRight : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private float MainCharSpeed;

    //float velocity;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float input_x = Input.GetAxisRaw("Horizontal");
        
            animator.SetFloat("input_x", input_x);

            transform.Translate(new Vector3(input_x, 0, 0).normalized * Time.deltaTime * 2f * MainCharSpeed);
        


    }
}
