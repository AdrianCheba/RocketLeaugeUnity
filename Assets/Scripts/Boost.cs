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
    public Image boost1;
    public Image boost2;
    float jump = 1f;


    private void Start()
    {
        carController = gameObject.GetComponentInChildren<CarController>();
        boost1 = boost1.GetComponent<Image>();
        boost2 = boost2.GetComponent<Image>();
        boost1.enabled = false;
        boost2.enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (counter < 2)
        {
            if (other.tag == "Booster")
            {
                counter += 1;
                boost1.enabled = true;
            }
        }

        if(counter == 2)
        {
            boost2.enabled = true;
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
                boost1.enabled = false;
                boost2.enabled = false;
            }  
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + jump, transform.localPosition.z);
        }
    }
}

