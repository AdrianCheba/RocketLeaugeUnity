using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.CrossPlatformInput;

public class Boost : MonoBehaviour
{
    public int counter = 0;
    public CarController carController;
    public Canvas can;
    float jump = 1f;


    private void Start()
    {
        carController = gameObject.GetComponentInChildren<CarController>();
        can = can.GetComponent<Canvas>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Booster")
        {
            counter += 1;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (counter >= 2)
            {
                carController.m_Rigidbody.velocity = ((carController.m_Topspeed / 3.6f) * carController.m_Rigidbody.velocity.normalized) * 2;
                counter = 0;
            }  
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + jump, transform.localPosition.z);
        }

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

