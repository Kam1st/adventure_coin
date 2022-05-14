using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimChar : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private LayerMask platformLayerMask;


    [SerializeField]
    private float MainCharSpeed;

    [SerializeField]
    private float jumpSpeed;

    private BoxCollider2D boxCollider2d;
    private Rigidbody2D rigidbody2d;

    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite full_heart;
    public Sprite empty_heart;



    float velocity;

    private void Awake()
    {
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }


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

        //GROUND RELATED
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {

            //rigidbody2d.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            rigidbody2d.velocity = Vector2.up * jumpSpeed;
        }


        //HEALTH RELATED
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }


        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = full_heart;
            }
            else
            {
                hearts[i].sprite = empty_heart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }


    private bool IsGrounded()
    {
        float extraHeigthText = .5f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f,  Vector2.down, extraHeigthText, platformLayerMask);

        /*
        Color rayColor;
        if(raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(boxCollider2d.bounds.center + new Vector3(boxCollider2d.bounds.extents.x, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeigthText),rayColor);
        Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeigthText), rayColor);
        Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, boxCollider2d.bounds.extents.y + extraHeigthText), Vector2.right * (boxCollider2d.bounds.extents.x), rayColor);
        Debug.Log(raycastHit.collider); */
        return raycastHit.collider != null;
    }


    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.transform.tag == "Spikes")
        {
            health--;
        }
        if (hit.transform.tag == "Spikes" && health == 0)
        {
            SceneManager.LoadScene("SceneL1GameOver");
        }
        if (hit.transform.tag == "RipSpikes")
        {
            SceneManager.LoadScene("SceneL1GameOver");
        }



        if (hit.transform.tag == "RareItem")
        {
            SceneManager.LoadScene("SceneL1Victory");
        }



        if (hit.transform.tag == "SpikesLvl2")
        {
            health--;
        }
        if (hit.transform.tag == "SpikesLvl2" && health == 0)
        {
            SceneManager.LoadScene("SceneL2GameOver");
        }
        if (hit.transform.tag == "RipSpikesLvl2")
        {
            SceneManager.LoadScene("SceneL2GameOver");
        }



        if (hit.transform.tag == "RareItemLvl2")
        {
            SceneManager.LoadScene("SceneL2Victory");
        }

        

        if (hit.transform.tag == "SpikesLvl3")
        {
            health--;
        }       
        if (hit.transform.tag == "SpikesLvl3" && health == 0)
        {
            SceneManager.LoadScene("SceneL3GameOver");
        }
        if (hit.transform.tag == "RipSpikesLvl3")
        {
            SceneManager.LoadScene("SceneL3GameOver");
        }



        if (hit.transform.tag == "RareItemLvl3")
        {
            SceneManager.LoadScene("SceneL3Victory");
        }
    }


}
