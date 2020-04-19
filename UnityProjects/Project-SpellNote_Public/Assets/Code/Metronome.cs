using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Metronome : MonoBehaviour
{
    public float bpm;
    //public int numBeatsPerSegment = 16;
    public AudioClip metronomeSound;

    private double nextEventTime;
    private AudioSource audioSource;
    private bool running = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        Debug.Log("Results: " + GetComponent<AudioSource>());
        audioSource.clip = metronomeSound;
        
        nextEventTime = AudioSettings.dspTime + 2.0f;
        running = true;
        //public float startTime = Time.time;
        Debug.Log("The start time was: " + AudioSettings.dspTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (!running)
        {
            return;
        }

        double time = AudioSettings.dspTime;

        if (time + 1.0f > nextEventTime)
        {
            // We are now approx. 1 second before the time at which the sound should play,
            // so we will schedule it now in order for the system to have enough time
            // to prepare the playback at the specified time. This may involve opening
            // buffering a streamed file and should therefore take any worst-case delay into account.
            audioSource.PlayScheduled(nextEventTime);
            Debug.Log("Scheduled tick to start at time " + nextEventTime);

            // Place the next event numBeatsPerSegment beats from here at a rate equal to the target bpm
            nextEventTime += 60.0f / bpm;
        }
        //audioSource.Play();
        //Debug.Log("Time at the start of this frame: " + Time.time);
        //Debug.Log("deltaTime: " + Time.deltaTime);
    }
}
