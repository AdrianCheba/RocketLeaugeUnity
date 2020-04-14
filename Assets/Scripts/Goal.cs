using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Canvas end;
    public int goal = 0;
    public int goal2 = 0;
    public Text goalTxt1;
    public Text goalTxt2;
    public Text goalTxt3;
    public float targetTime = 0;
    public int targetTime2 = 0;
    public int targetTime3 = 0;
    public GameObject car;
    Camera mainCam;
    public CameraController cC;



    private void Start()
    {
        goalTxt1 = goalTxt1.GetComponent<Text>();
        goalTxt2 = goalTxt2.GetComponent<Text>();
        goalTxt3 = goalTxt3.GetComponent<Text>();
        end = end.GetComponent<Canvas>();
        car = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)

    {
        if (other.tag == "Goal")
        {
            goal += 1;

            transform.localPosition = new Vector3(0, 0.5f, 0);
        }
        else if (other.tag == "Goal2")
        {
            goal2 += 1;
            transform.localPosition = new Vector3(0, 0.5f, 0);
        }
    }

    private void FixedUpdate()
    {
        goalTxt1.text = "" + goal;
        goalTxt2.text = "" + goal2;
        targetTime += Time.deltaTime;
        targetTime2 = (int)targetTime / 60;
        targetTime3 = (int)targetTime % 60; 

        goalTxt3.text = "0" + targetTime2 + " : " + "0" + targetTime3;
        if(targetTime3 >= 10) goalTxt3.text = "0" + targetTime2 + " : " + targetTime3;

        if(targetTime2 == 5)
        {
            Time.timeScale = 0;
            AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
            foreach (AudioSource source in aSources)
            {
                source.Pause();
            }
            end.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            cC.enabled = false;
        }

        mainCam = Camera.main;
        cC = mainCam.GetComponent<CameraController>();
    }
}
