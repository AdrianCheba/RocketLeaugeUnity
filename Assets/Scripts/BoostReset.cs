using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostReset : MonoBehaviour
{
    GameObject car;
    Vector3 orginalPos;
    public float targetTime = 60.0f;
    int flaga;

    private void Start()
    {
        orginalPos = transform.localPosition;
        car = GameObject.FindGameObjectWithTag("P1");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (car.gameObject.CompareTag("P1"))
        {
            transform.localPosition = new Vector3(0, 500, 0);
            flaga = 1;
        }
       
    }
    void Update()
    {
        if (flaga == 1)
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
    }
    void timerEnded()
    {
        transform.localPosition = orginalPos;
        targetTime = 60.0f;
        flaga = 0;
    }

}
