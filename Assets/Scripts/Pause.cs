using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Canvas can;
    public Canvas menu;
    public Canvas menu2;
    public Canvas menu3;
    public Button btnResume;
    public Button btnMenu;
    public GameObject ball;
    public GameObject car;
    public Goal goal;
    Camera mainCam;
    public CameraController cC;

    void Start()
    {
        can = can.GetComponent<Canvas>();
        menu = menu.GetComponent<Canvas>();
        menu2 = menu2.GetComponent<Canvas>();
        menu3 = menu3.GetComponent<Canvas>();
        btnMenu = btnMenu.GetComponent<Button>();
        btnResume = btnResume.GetComponent<Button>();
        ball = GameObject.Find("Ball");
        car = GameObject.FindGameObjectWithTag("Player");
        goal = ball.GetComponent<Goal>();

    }

    void Update()
    {
        if (menu.enabled == false & menu2.enabled == false & menu3.enabled == false) {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                cC.enabled = false;
                can.enabled = true;
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
                foreach (AudioSource source in aSources)
                {
                    source.Pause();
                }
            }
        }
        mainCam = Camera.main;
        cC = mainCam.GetComponent<CameraController>();

        if(Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.Space))
        {
            menu.enabled = false;
            menu2.enabled = false;
            menu3.enabled = false;
        }  if(Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.Space))
        {
            menu.enabled = false;
            menu2.enabled = false;
            menu3.enabled = false;
        }  if(Input.GetKey(KeyCode.D) & Input.GetKey(KeyCode.Space))
        {
            menu.enabled = false;
            menu2.enabled = false;
            menu3.enabled = false;
        }  if(Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.Space))
        {
            menu.enabled = false;
            menu2.enabled = false;
            menu3.enabled = false;
        }

    }

    public void BtnResume()
    {
                can.enabled = false;
                Time.timeScale = 1;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
                foreach (AudioSource source in aSources)
                {
                    source.Play();
                }
        cC.enabled = true;
    }

    public void BtnMenu()
    {
        can.enabled = false;
        menu.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
