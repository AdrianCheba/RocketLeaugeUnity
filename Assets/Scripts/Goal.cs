using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int goal = 0;
    public int goal2 = 0;
    private void OnTriggerExit(Collider other)
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cover1")
        {
            transform.localPosition = new Vector3(transform.localPosition.x - 2 ,transform.localPosition.y, transform.localPosition.z);
        }

        if (collision.gameObject.tag == "Cover2")
        {
            transform.localPosition = new Vector3(transform.localPosition.x + 2 ,transform.localPosition.y, transform.localPosition.z);
        }
    }
}
