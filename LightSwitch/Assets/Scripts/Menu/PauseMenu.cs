using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
 
    private static bool isPaused;

    
    void Start()
    {
       // pauseMenu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;

            if(isPaused)
            {   
                Debug.Log("Update called");
                    
                PauseGame();
                
               
            }
            else if (!isPaused)
            {
                ResumeGame();
                
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;   
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
           isPaused=false;
    }






}
