using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Debug.Log("Your Dark when scanner is white you Died");
        }
      /*  else if (colorDetection.spriteIsDark == false && DarkScanner)
        {
            Debug.Log("Your white when scanner is Dark you Died");
        }
*/
    }
}
