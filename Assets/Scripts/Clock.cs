
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


    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        TimeSpan timeSpan = time.TimeOfDay;

        // hoursPivot.localRotation = Quaternion.Euler(0f, 0f, -30f * (float)timeSpan.TotalHours);
        // minutesPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * (float)timeSpan.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * (float)timeSpan.Minutes);
    }
}
