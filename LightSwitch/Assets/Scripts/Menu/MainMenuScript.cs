using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{


public void ExitButton()
{
    Application.Quit();
    Debug.Log("Game Closed");

}


public void StartGame()
{
SceneManager.LoadScene("Level1");
}

public void MainMenu()
{
    Time.timeScale = 1f;
    SceneManager.LoadScene("MainMenu");
}


}

