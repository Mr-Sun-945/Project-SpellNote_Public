using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note
{
    //TODO: Refactor to be based on target time and hit time.
    //NOTE: Refactor dependant on an IdentifyNote function
    public string HitAccuracy(double beatsPassed)
    {
        // Accuracy Thresholds
        double excellent = .1;
        double good = .2;
        double okay = .325;

        // Other vars
        int nearestBeat = (int)Math.Round(beatsPassed);
        double accuracy = nearestBeat - beatsPassed;
        Debug.Log(accuracy);
        string quality;

        if (-excellent <= accuracy && accuracy <= excellent)
        {
            quality = "Excellent!";
        }
        else
        {
            if (-good <= accuracy && accuracy <= good)
            {
                quality = "Good!";
            }
            else 
            {
                if (-okay <= accuracy && accuracy <= okay)
                {
                    quality = "Okay";
                }
                else
                {
                    quality = "Poor";
                }
            }
        }
        
        return(quality);
    }

    public string IdentifyNote()
    {
        //
    }
}
