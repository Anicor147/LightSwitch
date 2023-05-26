using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScanDetection : MonoBehaviour
{
    public GameObject WhiteScanner;
   // public GameObject DarkScanner;

 public PlayerController colorDetection;

   bool whiteDetection = false;
   bool darkDetection = false;

 
 private void Start()
  {
    colorDetection = GetComponent<PlayerController>();
  }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (colorDetection.spriteIsDark == true && other.gameObject.tag == "WhiteScanner")
        {
            
             SceneManager.LoadScene("Level1");
        }
       else if (colorDetection.spriteIsDark == false && other.gameObject.tag == "DarkScanner")
        {
            
             SceneManager.LoadScene("Level1");
        }

    }
}
