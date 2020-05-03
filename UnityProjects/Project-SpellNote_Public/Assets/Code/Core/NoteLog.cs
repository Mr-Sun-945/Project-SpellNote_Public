using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteLog
{
    public List<double> log = new List<double>();

    public void AddEntry(double entry)
    {
        log.Add(entry);
    }

    public void WipeLog()
    {
        log = new List<double>();
    }
}

