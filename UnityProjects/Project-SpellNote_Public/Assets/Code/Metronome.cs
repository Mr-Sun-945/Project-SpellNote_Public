using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    public float bpm = 60.0f;
    public int numBeatsPerSegment = 16;
    public AudioClip metronomeSound;
    //public AudioClip[] clips = new AudioClip[2];
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = metronomeSound;
        audio.Play();
        //public float startTime = Time.time;
        //Debug.Log("The start time was: " + startTime);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().Play();
        UnityEngine.Debug.Log("Time at the start of this frame: " + Time.time);
        UnityEngine.Debug.Log("deltaTime: " + Time.deltaTime);
    }
}
