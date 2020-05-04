using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputCallbacks : MonoBehaviour
{
    private Note noteObj = new Note();
    private NoteLog noteLog = new NoteLog();

    public void OnNote(InputValue value)
    {
        Staff staff = gameObject.GetComponent<Staff>();

        double secondsPerBeat = 60.0d / staff.bpm;
        //Debug.Log("OnNote at Time = " + Time.time);
        //Debug.Log("secondsPerBeat = " + secondsPerBeat);

        double beatsPassed = (Time.time/secondsPerBeat) + 1;
        //Debug.Log("Beats Passed = " + beatsPassed);

        string accuracy = noteObj.HitAccuracy(beatsPassed);

        double quantizedHit = noteObj.QuantizeToMeasure(beatsPassed);
        double identifiedNote = noteObj.IdentifyNote(quantizedHit);

        noteLog.AddEntry(identifiedNote);
    }

    public void OnPrintLog(InputValue value)
    {
        Debug.Log(string.Join(",", noteLog.log));
    }

    public void OnWipeLog(InputValue value)
    {
        noteLog.WipeLog();
        Debug.Log("Log Wiped");
    }
    
    public void OnTestAction(InputValue value)
    {
        noteLog.ToNoteTypes();
    }
}
