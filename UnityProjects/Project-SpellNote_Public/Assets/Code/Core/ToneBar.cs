using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToneBar : MonoBehaviour
{
    public GameObject marker;
    public GameObject flatEnd;
    public GameObject sharpEnd;
    public int maxTone = 3;
    public float castingFeedbackLifespan;
    public Sprite castingFeedbackSprite;
    public GameObject castingFeedback;
    private int toneUpperLimit = 5;
    private int toneLowerLimit = 2;
    private float tickDistance = 0.5f; // Distance between each tick of intonation
    
    public int currentTone { get; private set; } = 0;  // 0=In Tune, -x=Flat, +x=Sharp

    public void Start()
    {
        // Start processes to initialize the ToneBar's size based on given values.
        ResetToneBar(maxTone);
    }

    public void ResetToneBar(int newMaxTone)
    {
        marker.transform.localPosition = new Vector3(0.0f, 0.0f, -0.2f);
        currentTone = 0;
        if (toneLowerLimit <= newMaxTone && newMaxTone <= toneUpperLimit)
        {
            maxTone = newMaxTone;
            float endPos = maxTone * tickDistance;
            flatEnd.transform.localPosition = new Vector3(0.0f, -endPos, -0.1f);
            sharpEnd.transform.localPosition = new Vector3(0.0f, endPos, -0.1f);
        }
    }

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

        // Adjust the tickDistance by the local scale component x
        Vector3 scale = transform.localScale;
        float tickDistanceScaled = tickDistance * scale.x;

        // Use the final delta amount to transform the marker appropriately
        Vector3 translateAmount = new Vector3(0.0f, tickDistanceScaled*amountDelta, 0.0f);
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

    public void FixedUpdate()
    {
        // Hiding the castingFeedback
        //castingFeedback.GetComponent<Renderer>().enabled = false;
        castingFeedback.GetComponent<SpriteRenderer>().sprite = castingFeedbackSprite;
    }
}
