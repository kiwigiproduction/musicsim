using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateTimeManager : MonoBehaviour
{
    public Text time;

    private string date;
    public DateTime dateTime = new DateTime(2000, 1, 1,12,0,0);

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        date = dateTime.ToString();
        time.text = date;
    }

    //public void AddHour() 
    //{
    //    //while(true)
    //    //{
    //    //    dateTime.AddHours(1);
    //    //    time.text = dateTime.ToString();
    //    //}
        
    //}

    // Update is called once per frame
    void Update()
    {
        dateTime = dateTime.AddHours(1.0/30.0);
        date = dateTime.ToString();
        time.text = date;
        Debug.Log(time.text);
    }
}
