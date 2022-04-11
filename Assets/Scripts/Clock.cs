
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
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
        DateTime time = DateTime.Now;
        TimeSpan timeSpan = time.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(30f * (float)timeSpan.TotalHours, 0f, 0f);
        minutesPivot.localRotation = Quaternion.Euler(6f * (float)timeSpan.TotalMinutes, 0f, 0f);
        secondsPivot.localRotation = Quaternion.Euler(6f * (float)timeSpan.Seconds, 0f, 0f);
    }
}
