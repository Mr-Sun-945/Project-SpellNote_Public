using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measure : MonoBehaviour
{
    // Public vars
    public GameObject metronome_object;

    public Vector3 translateDirection;

    // Private vars
    private UnityMetronome metronome_script;
    private double bpm;

    private double measureSize = 10; // World space size of a measure; dependant on asset size
    private double beatSize;
    private double bps;
    private float distancePerSecond;
    private Transform childMeasure;

    // Start is called before the first frame update
    void Start()
    {
        // Get the BPM of the metronome
        UnityMetronome metronome_script = metronome_object.GetComponent<UnityMetronome>();
        bpm = metronome_script.bpm;
        Debug.Log("Current BPM = " + bpm);

        // Calculate world-space size of a beat based on measure size
        beatSize = measureSize / 4; 
        Debug.Log("Beat Size = " + beatSize);

        // Calculate the distance moved per second
        bps = bpm / 60.0f;
        distancePerSecond = (float)(bps * beatSize);
        Debug.Log("Distance Per Second = " + distancePerSecond);

        // Get child measure to transform
        childMeasure = gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 frameDelta = translateDirection * Time.deltaTime * distancePerSecond;
        //Debug.Log("Frame Delta = " + frameDelta);
        childMeasure.Translate(frameDelta);
    }
}
