
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    bool continuous = false;

    [SerializeField]
    Transform hoursPivot;
    [SerializeField]
    Transform minutesPivot;
    [SerializeField]
    Transform secondsPivot;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan timeSpan = DateTime.Now.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(30f * (float)timeSpan.TotalHours, 0f, 0f);
        minutesPivot.localRotation = Quaternion.Euler(6f * (float)timeSpan.TotalMinutes, 0f, 0f);

        if(continuous)
            secondsPivot.localRotation = Quaternion.Euler(6f * (float)timeSpan.TotalSeconds, 0f, 0f);
        else
            secondsPivot.localRotation = Quaternion.Euler(6f * (float)timeSpan.Seconds, 0f, 0f);
    }
}
