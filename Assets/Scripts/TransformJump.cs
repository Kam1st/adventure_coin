using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TransformJump : MonoBehaviour
{
    [SerializeField]
    private float jumpSpeed;

    
    
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
        
    }

    

}
