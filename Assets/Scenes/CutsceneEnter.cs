using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutscenecam;
    void OnTriggerEnter(Collider other)
    {
        cutscenecam.SetActive(true);
        thePlayer.SetActive(false);
    }
}