using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private float RunSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float input_x = Input.GetAxisRaw("Horizontal");
        float input_y = Input.GetAxisRaw("Vertical");

        bool IsWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;

        anim.SetBool("is_walking", IsWalking);
        if (IsWalking)
        {
            anim.SetFloat("input_x", input_x);
            anim.SetFloat("input_y", input_y);

            if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                transform.position += new Vector3(input_x, input_y, 0).normalized * Time.deltaTime;
            }
            else
            {
                transform.position += new Vector3(input_x, input_y, 0).normalized * Time.deltaTime * RunSpeed;
            }
        }
    }
}
