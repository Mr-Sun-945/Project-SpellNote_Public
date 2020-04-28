using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    // Public vars
    public GameObject metronomeObject;
    public Texture2D measureTexture;
    public Vector3 translateDirection;
    public double maxMeasures = 4;

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

    public double bpm { get; private set; }
    public float startTime { get; private set; }
    public float measureLifespan { get; private set; }
    public Vector3 frameDelta { get; private set; }

    // Perform all other-object data queries prior to Start
    void Awake()
    {
        UnityMetronome metronomeScript = metronomeObject.GetComponent<UnityMetronome>();
        bpm = metronomeScript.bpm;
        Debug.Log("Current BPM = " + bpm);

        measurePixelWidth = measureTexture.width;
        measurePixelHeight = measureTexture.height;
    }

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        Debug.Log("Start Time = " + startTime);
        // Calculate the world width of a measure / beat
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
        //CreateMeasure(new Vector3(0.0f, 0.0f, 0.0f));
        //previousMeasure = CreateMeasure(new Vector3(measureWorldWidth, 0.0f, 0.0f));
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Calculate the per frame movement to be used by the child measures
        frameDelta = translateDirection * Time.deltaTime * distancePerSecond;
        timePassed += Time.deltaTime;
        if (nextMeasureTime <= Time.time)
        {
            // NOTE: Disabling these 2 lines because they cause the measures to drift off-beat
            //float prevX = previousMeasure.transform.position.x;
            //float xStartPos = prevX + measureWorldWidth;
            previousMeasure = CreateMeasure(new Vector3(measureWorldWidth, 0.0f, 0.0f));
            timePassed = 0.0f;
        }
    }

    // Function to create a measure
    GameObject CreateMeasure(Vector3 spawnVector)
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

        Measure measureScript = measureGO.AddComponent<Measure>() as Measure;

        // Calculate when the next measure needs to be made
        nextMeasureTime = Time.time + measureDuration;
        //Debug.Log("Next Measure Spawning At: " + nextMeasureTime);

        return measureGO;
    }
}
