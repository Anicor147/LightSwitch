using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float walkSpeed = 0f;
    [SerializeField] float jumpHeight = 0f;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Sprite spriteSwitchWhite;
    public Sprite spriteSwitchDark;
    Vector2 bodyMouvement;
    int jumpCount = 0;
    public bool spriteIsDark = false;
    float moveInput = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Mouvement();
        ChangeSprite();
        SpriteDirection();
    }

    void Mouvement()
    {
        /*
        float horizontalMouvement = Input.GetAxis("Horizontal") * walkSpeed * Time.deltaTime;
        float verticalMouvement = Input.GetAxis("Jump") * jumpHeight *  Time.deltaTime;
        transform.Translate(horizontalMouvement,verticalMouvement,0);    
        */
        
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity  = new Vector2 (moveInput * walkSpeed , rb.velocity.y );
        //rb.velocity = bodyMouvement * walkSpeed ;
       
       if(Input.GetButtonDown("Jump"))
       {
        if(jumpCount < 1 )
        {
            if(jumpCount == 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
               
            }/*
            else
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
                
            }*/
            jumpCount++;
        }
       }         
    }

    void SpriteDirection()
    {
        if(moveInput > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if(moveInput < 0)
        {
            spriteRenderer.flipX =true;
        }
    }

    void  OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" )
        {
            jumpCount = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
          if (trigger.gameObject.tag == "Void")
          {
            
            SceneManager.LoadScene("Level1");
          }
        
    }


    void ChangeSprite()
    {

        if(Input.GetKeyDown(KeyCode.E) && !spriteIsDark)
        {
            
            SpriteChangeToDark();
            spriteIsDark = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && spriteIsDark )
        {
            
            SpriteChangeToWhite();
            spriteIsDark = false;
        } 
    }



    void  SpriteChangeToWhite()
    { 
        Debug.Log("Sprite is White");
        spriteRenderer.sprite = spriteSwitchWhite;
    }
    
    void  SpriteChangeToDark()
    {
        Debug.Log("Sprite is Dark");
        spriteRenderer.sprite = spriteSwitchDark;
        
    }
}
