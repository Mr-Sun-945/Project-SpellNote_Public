using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteLog
{
    public List<double> log = new List<double>();

    public void AddEntry(double entry)
    {
        foreach (var item in log) // Rough filer to help prevent the filter from having >1 measure
        {
            if (entry < item)
            {
                return;
            }
        }
        log.Add(entry);
    }

    public void ToNoteTypes()
    {
        // Create a working log and add 5 as the final beat to calculate from
        List<double> workingLog = new List<double>(log);
        workingLog.Add(5);

        List<string> stringLog = new List<string>();
        for (var i = 0; i < workingLog.Count-1; i++)
        {
            double noteLength = workingLog[i+1] - workingLog[i];
            if (noteLength == 1)
            {
                stringLog.Add(workingLog[i] + ": Quarter");
                continue;
            }

            if (noteLength == .5)
            {
                stringLog.Add(workingLog[i] + ": Eighth");
                continue;
            }

            if (noteLength == .25)
            {
                stringLog.Add(workingLog[i] + ": Sixteenth");
                continue;
            }
            stringLog.Add(workingLog[i] + ": Unidentified Length (" + noteLength + ")");
        }

        //Debug.Log(string.Join(",", workingLog));
        Debug.Log(string.Join(",", stringLog));
    }

    public void WipeLog()
    {
        log = new List<double>();
    }
}

