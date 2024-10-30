using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleScene: MonoBehaviour
{
    void OnEnable(){
        SceneManager.LoadScene("END", LoadSceneMode.Single);
    }
}