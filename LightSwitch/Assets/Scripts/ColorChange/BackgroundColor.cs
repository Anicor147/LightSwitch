using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
   public Color colorWhite = Color.white;
   public Color colorDark = Color.black;

    public Camera cameraBackground;
    [SerializeField] float invokeTimer;
    
    void Start()
    {
        ChangeToWhite();
    }
    



    void ChangeToWhite()
    {
       cameraBackground.backgroundColor = colorWhite;
       Invoke("ChangeToDark" , invokeTimer);
    }

    void ChangeToDark()
    {
        cameraBackground.backgroundColor = colorDark;
        Invoke("ChangeToWhite" , invokeTimer);
    }


}
