using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;
    void Start()
    {

    }

    void Update()
    {

    }
    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }
    public void QuitGames()
    {
        Application.Quit();
    }
}