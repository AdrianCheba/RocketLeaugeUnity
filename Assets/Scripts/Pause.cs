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
    Vector3 startPos;

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
        startPos = car.transform.localPosition;
        goal = ball.GetComponent<Goal>();
    }

    void Update()
    {
        if (menu.enabled == false & menu2.enabled == false & menu3.enabled == false) {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
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
    }

    public void BtnMenu()
    {
        can.enabled = false;
        menu.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
