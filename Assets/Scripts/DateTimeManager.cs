using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateTimeManager : MonoBehaviour
{
    public Text time;

    private string date;
    private int counter;
    public Button playNorm;
    public DateTime dateTime = new DateTime(2000, 1, 1,12,0,0);

    public DateTime CurrentDateTime = new DateTime(2000, 1, 1,12,0,0);

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 1;
        date = dateTime.ToString();
        time.text = date;
    }

    public void AddHourNormalSpeed()
    {
        int id = 1;
        dateTime = dateTime.AddHours(1.0 / 60.0);
        //date = dateTime.ToString();
        time.text = dateTime.ToString();
        counter = id;
    }

    public void AddHourFastSpeedClick()
    {
        int id = 2;
        CurrentDateTime = CurrentDateTime.AddHours(3);
        time.text = CurrentDateTime.ToString();
        counter = id;
    }

    // Update is called once per frame
    void Update()
    {
        //switch (counter)
        //{
        //    //case 1:
            
        //}
        CurrentDateTime = CurrentDateTime.AddHours(1.0);
        time.text = CurrentDateTime.ToString();// (Time.deltaTime);

    }
}
