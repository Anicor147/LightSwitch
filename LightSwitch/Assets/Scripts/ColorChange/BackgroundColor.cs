using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
   public Color colorWhite = Color.white;
   public Color colorDark = Color.black;
    bool backIsDark = true;
    public Camera cameraBackground;
    [SerializeField] float invokeTimer;
    
    void Start()
    {
  //      ChangeToWhite();
    }
    
    void Update()
    {
        ChangeBackground();
    }
    
/* void ChangeToWhite()
    {
       cameraBackground.backgroundColor = colorWhite;
       
    }
*/


        void ChangeBackground()
    {

        if(Input.GetKeyDown(KeyCode.E) && !backIsDark)
        {
            
            cameraBackground.backgroundColor = colorDark;
            backIsDark = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && backIsDark)
        {
            
           cameraBackground.backgroundColor = colorWhite;
            backIsDark = false;
        } 
    }

}
