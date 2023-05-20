using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float walkSpeed = 0f;
    [SerializeField] float jumpHeight = 0f;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Sprite spriteSwitchWhite;
    public Sprite spriteSwitchDark;
    Vector2 bodyMouvement;
    
    private bool spriteIsDark = false;
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
    }

    void Mouvement()
    {
        /*
        float horizontalMouvement = Input.GetAxis("Horizontal") * walkSpeed * Time.deltaTime;
        float verticalMouvement = Input.GetAxis("Jump") * jumpHeight *  Time.deltaTime;
        transform.Translate(horizontalMouvement,verticalMouvement,0);    
        */
        

        rb.velocity  = new Vector2 (Input.GetAxisRaw("Horizontal") * walkSpeed , rb.velocity.y );
        //rb.velocity = bodyMouvement * walkSpeed ;
       
       if(Input.GetButtonDown("Jump"))
       {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
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
