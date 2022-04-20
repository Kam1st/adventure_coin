using UnityEngine;
public class GroundCheck : MonoBehaviour
{
    public float distanceToCheck = 0.5f;
    public bool isGrounded;
    private void Update()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, distanceToCheck))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
