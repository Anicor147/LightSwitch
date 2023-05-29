using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineScript : MonoBehaviour
{
    MainMenuScript menu;
  private void OnTriggerEnter2D(Collider2D other)
   {
    if(other.tag == "Player")
    {
        Debug.Log("finish");
        Invoke("EndScreen", 2f);
        
    }
  }

  public void EndScreen()
{
    SceneManager.LoadScene("End");
}


}
