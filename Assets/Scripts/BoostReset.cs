using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostReset : MonoBehaviour
{
    GameObject car;
    public Boost b;
    public GameObject partner;
    Vector3 orginalPos;
    public float targetTime = 60.0f;
    int flaga;

    private void Start()
    {
        orginalPos = transform.localPosition;
        car = GameObject.FindGameObjectWithTag("Player");
        partner = GameObject.FindGameObjectWithTag("Player");
        b = partner.GetComponent<Boost>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (b.counter < 2)
        {
            if (car.gameObject.CompareTag("Player"))
            {
                transform.localPosition = new Vector3(0, 500, 0);
                flaga = 1;
            }
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
