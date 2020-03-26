using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Canvas can;
    public Canvas HUD;
    public Button btnStart;
    public Button btnQuit;

    void Start()
    {
        can = can.GetComponent<Canvas>();
        HUD = HUD.GetComponent<Canvas>();
        btnStart = btnStart.GetComponent<Button>();
        btnQuit = btnQuit.GetComponent<Button>();
        HUD.enabled = false;
        Time.timeScale = 0;
    }


    public void BtnStart()
    {
        can.enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        HUD.enabled = true;
        AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource source in aSources)
        {
            source.Play();
        }
    }

    public void BtnQuit()
    {
        Application.Quit();
    }

}
