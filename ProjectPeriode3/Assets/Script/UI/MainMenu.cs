using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    // Scene manager to load into the game
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    // Allows the player to quit the game
    public void QuitGame()
    {
        Debug.Log("Quit game succesfully!");
        Application.Quit(); 
    }
}
