using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Canvas can; 

    void Start()
    {
        can = can.GetComponent<Canvas>();
    }

    void Update()
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
        }
    }
}
