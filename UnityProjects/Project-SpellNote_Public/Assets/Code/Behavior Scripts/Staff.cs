using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    // Public vars
    public Note note;
    public Texture2D measureTexture;
    public Vector3 translateDirection;
    public double maxMeasures = 4;

    public ToneBar toneBarP1;
    public ToneBar toneBarP2;

    // Private vars
    private Vector2 pivotPoint = new Vector2(0.0f, 0.5f); // Pivot aligned to left-center
    private float pixelsPerUnit = 100.0f;
    private float measurePixelWidth;
    private float measurePixelHeight;
    private float measureWorldWidth;
    private float beatWorldWidth;

    private float measureDuration;

    private double bps; // Beats Per Second
    private float distancePerSecond;

    private float nextMeasureTime;

    private Sprite measureSprite;

    private GameObject previousMeasure;
    private float timePassed = 0.0f;

    private bool spawnPlayableMeasure = true;
    private bool currentMeasurePlayable;

    // Public get, private set
    public double bpm { get; private set; }
    public float startTime { get; private set; }
    public float measureLifespan { get; private set; }
    public Vector3 frameDelta { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        // Grab bpm from the note object
        bpm = note.bpm;
        Debug.Log("Current BPM = " + bpm);

        startTime = Time.time;
        Debug.Log("Start Time = " + startTime);

        // Calculate the world width of a measure / beat
        measurePixelWidth = measureTexture.width;
        measurePixelHeight = measureTexture.height;

        measureWorldWidth = measurePixelWidth / pixelsPerUnit;
        Debug.Log("Measure Size = " + measureWorldWidth);
        beatWorldWidth = measureWorldWidth / 4;
        Debug.Log("Beat Size = " + beatWorldWidth);
        
        // Calculate the time duration of a single measure
        float beatDuration = (float)(60.0f / bpm);
        measureDuration = (float)(beatDuration * 4.0);
        Debug.Log("Measure Duration = " + measureDuration);

        // Calculate the lifespan of a measure
        measureLifespan = (float)maxMeasures * measureDuration;

        // Calculate the distance moved per second
        bps = bpm / 60.0f;
        distancePerSecond = (float)(bps * beatWorldWidth);
        Debug.Log("Distance Per Second = " + distancePerSecond);

        // Create the measure sprite
        measureSprite = Sprite.Create(measureTexture, 
                                             new Rect(0.0f, 0.0f, measurePixelWidth, measurePixelHeight),
                                             pivotPoint,
                                             pixelsPerUnit);

        // Create initial measures
        //CreateMeasure(new Vector3(0.0f, 0.0f, 0.0f), spawnPlayableMeasure);
        //previousMeasure = CreateMeasure(new Vector3(measureWorldWidth, 0.0f, 0.0f), false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Calculate the per frame movement to be used by the child measures
        frameDelta = translateDirection * Time.deltaTime * distancePerSecond;
        timePassed += Time.deltaTime;
        if (nextMeasureTime <= Time.time)
        {
            // TODO: Add a calculation to account for the offset missing due to irrational division?
            // Find the remainder of BPM / 60 (or whatever calculation) and adjust the initial spawn point?
            // May still cause drift or inaccurate audio/hitMarker

            // NOTE: Disabling these 2 lines because they cause the measures to drift off-beat
            //float prevX = previousMeasure.transform.position.x;
            //float xStartPos = prevX + measureWorldWidth;
            previousMeasure = CreateMeasure(new Vector3(measureWorldWidth, 0.0f, 0.0f), spawnPlayableMeasure);
            spawnPlayableMeasure = !spawnPlayableMeasure;
            timePassed = 0.0f;
        }
        
        // If we've just switched from a playable measure to an unplayable measure...
        if (note.IsMeasurePlayable() != currentMeasurePlayable && currentMeasurePlayable == true)
        {
            bool p1Loss = false;
            bool p2Loss = false;
            // Check victory condition
            // Check both tone bars to see if either is broken (i.e. currentTone == maxTone)
            if (Math.Abs(toneBarP1.currentTone) == toneBarP1.maxTone)
            {
                p1Loss = true;
            }
            if (Math.Abs(toneBarP2.currentTone) == toneBarP2.maxTone)
            {
                p2Loss = true;
            }

            // If at least one person lost, log it and restart the tone bars
            if (p1Loss == true || p2Loss == true)
            {
                Debug.Log("Match over!");
                // Log the winner
                if (p1Loss == true && p2Loss == true)
                {
                    Debug.Log("It's a draw!");
                }
                else if (p1Loss == true)
                {
                    Debug.Log("Player 2 Wins!");
                }
                else
                {
                    Debug.Log("Player 1 Wins!");
                }

                // Reset the tone bars
                toneBarP1.ResetToneBar(toneBarP1.maxTone);
                toneBarP2.ResetToneBar(toneBarP2.maxTone);
            }
        }
        
        // Update currentMeasurePlayable
        currentMeasurePlayable = note.IsMeasurePlayable();
    }

    // Function to create a measure
    private GameObject CreateMeasure(Vector3 spawnVector, bool measureOn)
    {
        //Debug.Log("Creating a measure!");
        //Debug.Log("Measure Spawn Vector = " + spawnVector);
        // Create a measure
        GameObject measureGO = new GameObject();
        measureGO.transform.Translate(spawnVector);
        measureGO.name = (string) "Measure";
        measureGO.transform.SetParent(gameObject.transform);

        SpriteRenderer measureSR = measureGO.AddComponent<SpriteRenderer>() as SpriteRenderer;
        measureSR.sprite = measureSprite;

        if (measureOn == false)
        {
        measureSR.color = new Color(0.1f, 0.1f, 0.1f);
        }

        Measure measureScript = measureGO.AddComponent<Measure>() as Measure;

        // Calculate when the next measure needs to be made
        nextMeasureTime = Time.time + measureDuration;
        //Debug.Log("Next Measure Spawning At: " + nextMeasureTime);

        return measureGO;
    }
}
