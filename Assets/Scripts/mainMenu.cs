using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.sceneCount);
    }
    public void ExitGame()
    {
        
        
            Application.Quit();
        
    }
    public void PassLevel()
    {
        SceneManager.LoadScene(SceneManager.sceneCount + 1);
    }
    public void LoadBlurg()
    {
        SceneManager.LoadScene(3);
    }
   
}
