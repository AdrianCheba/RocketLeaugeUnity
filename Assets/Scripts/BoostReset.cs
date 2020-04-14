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
    int flaga2 = 0;

    private void Start()
    {
        orginalPos = transform.localPosition;
        car = GameObject.FindGameObjectWithTag("Player");
       
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
        
            
        if ((transform.localPosition.y < 1.16f) & flaga2 == 0)
        {
            transform.Translate(new Vector3(0, 0.4f, 0) * Time.deltaTime);
        }

        if ((transform.localPosition.y > 0.39f) & flaga2 == 1)
        {
            transform.Translate(new Vector3(0, -0.4f, 0) * Time.deltaTime);
        }

        if (transform.localPosition.y > 1.15f) flaga2 = 1;
        if (transform.localPosition.y < 0.40f) flaga2 = 0;

        partner = GameObject.FindGameObjectWithTag("Player");
        b = partner.GetComponent<Boost>();
    }
    void timerEnded()
    {
        transform.localPosition = orginalPos;
        targetTime = 60.0f;
        flaga = 0;
    }

}
