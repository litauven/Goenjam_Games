using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END: MonoBehaviour
{
    void OnEnable(){
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}