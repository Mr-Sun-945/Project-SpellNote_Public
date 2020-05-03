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
        //Debug.Log(accuracy);
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

    public double IdentifyNote(double beatsPassed)
    {
        // Add bias for human error
        beatsPassed = beatsPassed -.05;

        // Convert beat to a 1/4 fraction (x, x.25, x.5, x.75)
        double beatHit = Math.Round(beatsPassed * 4) / 4;
        
        // Remove the int value of the hit, taking only the decimal after
        double fractionHit = beatHit - Math.Truncate(beatHit);

        return beatHit;
    }

    public double QuantizeToMeasure(double beat)
    {
        // Quantizes to a 0-3 range, i.e. beat 1/2/3/4
        return beat - (Math.Floor((beat - 1) / 4) * 4);  //NOTE: .Floor may need to be replaced with .Round
    }
}
