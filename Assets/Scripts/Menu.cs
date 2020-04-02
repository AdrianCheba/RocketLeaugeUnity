using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Canvas can;
    public Canvas HUD;
    public Canvas carMenu;
    public Canvas groundMenu;
    public Button btnStart;
    public Button btnPlay;
    public Button btnPlay2;
    public Button btnPlay3;
    public Button btnPlay4;
    public Button btnPlay5;
    public Button btnPlay6;
    public Button btnBack;
    public Button btnQuit;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject Ground;
    public GameObject Ground2;
    public GameObject Ground3;

    void Start()
    {
        can = can.GetComponent<Canvas>();
        HUD = HUD.GetComponent<Canvas>();
        carMenu = carMenu.GetComponent<Canvas>();
        groundMenu = groundMenu.GetComponent<Canvas>();
        btnStart = btnStart.GetComponent<Button>();
        btnPlay = btnPlay.GetComponent<Button>();
        btnPlay2 = btnPlay2.GetComponent<Button>();
        btnPlay3 = btnPlay3.GetComponent<Button>();
        btnPlay4 = btnPlay3.GetComponent<Button>();
        btnPlay5 = btnPlay3.GetComponent<Button>();
        btnPlay6 = btnPlay3.GetComponent<Button>();
        btnBack = btnBack.GetComponent<Button>();
        btnQuit = btnQuit.GetComponent<Button>();
        car1 = GameObject.Find("car1");
        car2 = GameObject.Find("car2");
        car3 = GameObject.Find("car3");
        Ground = GameObject.Find("FootballPitch");
        Ground2 = GameObject.Find("FootballPitch2");
        Ground3 = GameObject.Find("FootballPitch3");

        HUD.enabled = false;
        carMenu.enabled = false;
        groundMenu.enabled = false;
        Time.timeScale = 0;
    }


    public void BtnStart()
    {
        carMenu.enabled = true;
        can.enabled = false;
    }

    public void BtnPlay()
    {
        car2.SetActive(false);
        car3.SetActive(false);
        carMenu.enabled = false;
        groundMenu.enabled = true;
    } 

    public void BtnPlay2()
    {
        car1.SetActive(false);
        car3.SetActive(false);
        carMenu.enabled = false;
        groundMenu.enabled = true;
    } 

    public void BtnPlay3()
    {
        car2.SetActive(false);
        car1.SetActive(false);
        carMenu.enabled = false;
        groundMenu.enabled = true;
    } 
    
    public void BtnPlay4()
    {
        Ground2.SetActive(false);
        Ground3.SetActive(false);
        groundMenu.enabled = false;
        HUD.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource source in aSources)
        {
            source.Play();
        }
    }    

    public void BtnPlay5()
    {
        Ground.SetActive(false);
        Ground3.SetActive(false);
        groundMenu.enabled = false;
        HUD.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource source in aSources)
        {
            source.Play();
        }
    }   
    
    public void BtnPlay6()
    {
        Ground2.SetActive(false);
        Ground.SetActive(false);
        groundMenu.enabled = false;
        HUD.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource source in aSources)
        {
            source.Play();
        }
    }
    public void BtnBack()
    {
        carMenu.enabled = false;
        can.enabled = true;
    } 
    public void BtnBack2()
    {
        groundMenu.enabled = false;
        carMenu.enabled = true;
    }

    public void BtnQuit()
    {
        Application.Quit();
    }

}
