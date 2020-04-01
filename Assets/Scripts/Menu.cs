using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Canvas can;
    public Canvas HUD;
    public Canvas carMenue;
    public Button btnStart;
    public Button btnPlay;
    public Button btnPlay2;
    public Button btnPlay3;
    public Button btnBack;
    public Button btnQuit;

    void Start()
    {
        can = can.GetComponent<Canvas>();
        HUD = HUD.GetComponent<Canvas>();
        carMenue = carMenue.GetComponent<Canvas>();
        btnStart = btnStart.GetComponent<Button>();
        btnPlay = btnPlay.GetComponent<Button>();
        btnPlay2 = btnPlay2.GetComponent<Button>();
        btnPlay3 = btnPlay3.GetComponent<Button>();
        btnBack = btnBack.GetComponent<Button>();
        btnQuit = btnQuit.GetComponent<Button>();
        HUD.enabled = false;
        carMenue.enabled = false;
        Time.timeScale = 0;
    }


    public void BtnStart()
    {
        carMenue.enabled = true;
        can.enabled = false;
    }

    public void BtnPlay()
    {

    } 

    public void BtnPlay2()
    {

    } 

    public void BtnPlay3()
    {

    }
    public void BtnBack()
    {

    }

    public void BtnQuit()
    {
        Application.Quit();
    }

}
