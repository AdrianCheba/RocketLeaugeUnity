using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Canvas can;
    int flag = 0;

    void Start()
    {
        can = can.GetComponent<Canvas>();
    }

    void Update()
    {
        if (flag == 0)
        {
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

                flag = 1;
            }
        }
        else if(flag == 1)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
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

                flag = 0;
            }
        }
    }
}
