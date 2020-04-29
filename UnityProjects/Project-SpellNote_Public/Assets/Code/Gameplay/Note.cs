using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note
{
    public string HitAccuracy(int nearestBeat, double accuracy)
    {
        double quality = accuracy - nearestBeat;
        return("Results!");
    }
}
