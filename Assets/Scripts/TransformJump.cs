using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TransformJump : MonoBehaviour
{
    [SerializeField]
    private float jumpSpeed;
    
    void Update()
    {
        var x = Physics2D.Raycast(transform.position, new Vector3(0, -1, 0), 2);

        if (Input.GetKeyDown(KeyCode.Space) && x != null)
        {
            
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
        
    }
}
