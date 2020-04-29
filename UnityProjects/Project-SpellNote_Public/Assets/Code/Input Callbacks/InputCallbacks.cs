using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputCallbacks : MonoBehaviour
{
    private Note noteObj = new Note();

    public void OnNote(InputValue value)
    {
        Staff staff = gameObject.GetComponent<Staff>();

        double secondsPerBeat = 60.0d / staff.bpm;
        //Debug.Log("OnNote at Time = " + Time.time);
        //Debug.Log("secondsPerBeat = " + secondsPerBeat);

        double beatsPassed = (Time.time/secondsPerBeat) + 1;
        //Debug.Log("Beats Passed = " + beatsPassed);

        int nearestBeat = (int)Math.Round(beatsPassed);
        //Debug.Log("Nearest Beat = " + nearestBeat);

        double accuracy = nearestBeat - beatsPassed;
        Debug.Log("Accuracy = " + accuracy);

        string result = noteObj.HitAccuracy(nearestBeat, accuracy);
        Debug.Log(result);
    }
}
