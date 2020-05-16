using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToneBar : MonoBehaviour
{
    public GameObject marker;
    public int maxTone = 3;
    private int currentTone = 0;  // 0=In Tune, -x=Flat, +x=Sharp
    private float tickDistance = 0.5f; // Distance between each tick of intonation

    private void UpdateTone(int amount)
    {
        // Calculate what currentTone will be updated to based on the update amount
        int newTone;
        newTone = currentTone + amount;

        // Constrain the tone to be within the maxTone boundaries
        if (newTone > maxTone)
        {
            newTone = maxTone;
        }
        if (newTone < -maxTone)
        {
            newTone = -maxTone;
        }

        // Calculate the delta after constraining to the maxTone boundary
        int amountDelta = newTone - currentTone;

        // Update the currentTone based on the final delta amount
        currentTone += amountDelta;

        // Use the final delta amount to transform the marker appropriately
        Vector3 translateAmount = new Vector3(tickDistance*amountDelta, 0.0f, 0.0f);
        marker.transform.Translate(translateAmount);
    }

    public void GoFlat(int amount)
    {
        UpdateTone(-amount);
    }

    public void GoSharp(int amount)
    {
        UpdateTone(amount);
    }
}
