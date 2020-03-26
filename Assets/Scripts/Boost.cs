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
    float jump = 1f;


    private void Start()
    {
        carController = gameObject.GetComponentInChildren<CarController>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (counter < 2)
        {
            if (other.tag == "Booster")
            {
                counter += 1;
            }
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
    }
}

