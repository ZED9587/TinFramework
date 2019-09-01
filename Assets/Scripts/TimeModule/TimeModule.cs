using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeModule : IMonoModule
{
    public void InitModule()
    {
        
    }

    public void ReleaseModle()
    {
        
    }

    public void UpdateModule()
    {
        
    }

    /// <summary>
    /// delay action.
    /// </summary>
    /// <param name="seconds"></param>
    /// <param name="action"></param>
    public void DelayNSeconds(int seconds,UnityAction action) {

    }

    public DateTime Now() {
        return DateTime.Now;
    }

    public DateTime GetHoursLater(int hours) {
        DateTime dateTime = Now();
        dateTime.AddHours(hours);
        return dateTime;
    }
}
