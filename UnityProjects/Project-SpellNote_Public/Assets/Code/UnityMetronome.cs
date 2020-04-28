using UnityEngine;
using System.Collections;

// The code example shows how to implement a metronome that procedurally generates the click sounds via the OnAudioFilterRead callback.
// While the game is paused or the suspended, this time will not be updated and sounds playing will be paused. Therefore developers of music scheduling routines do not have to do any rescheduling after the app is unpaused

[RequireComponent(typeof(AudioSource))]
public class UnityMetronome: MonoBehaviour
{
    public double bpm = 140.0F;
    public float gain = 0.5F;
    public int signatureHi = 4;
    public int signatureLo = 4;
    private double nextTick = 0.0F;
    private float amp = 0.0F;
    private float phase = 0.0F;
    private double sampleRate = 0.0F;
    private int accent;
    private bool running = false;
    void Start()
    {
        accent = signatureHi;
        double startTick = AudioSettings.dspTime;
        sampleRate = AudioSettings.outputSampleRate; // System sample rate (ex. 48000)
        nextTick = startTick * sampleRate;
        running = true;
    }

    void OnAudioFilterRead(float[] data, int channels)
    {
        if (!running)
            return;

        double samplesPerTick = sampleRate * 60.0F / bpm * 4.0F / signatureLo;
        double sample = AudioSettings.dspTime * sampleRate;
        int dataLen = data.Length / channels; // data.Length = 2048, channels = 2, dataLen = 1024
        int n = 0;
        while (n < dataLen) // This while loop runs 1024 times before n resets to 0
        {
            // Generate sin wave values based on the gain (volume, sort of. Technically just "an increase")
            // the amplitude,
            float x = gain * amp * Mathf.Sin(phase);
            int i = 0;
            while (i < channels) // 2 channels, so "i" flips between values of 0 and 1 (1 flip / loop)
                // This while loop runs 2 times before i resets to 0
                // n * channels + i allows us to iterate through 2 times the value of n
                // Ex. n = 1024, this loop allows us to iterate through values 0-2047
            {
                // Update entries in "data" w/ "x", which is fluctuating through sin wave values.
                data[n * channels + i] += x;
                i++;
            }
            while (sample + n >= nextTick)
            {
                nextTick += samplesPerTick;
                amp = 1.0F;
                if (++accent > signatureHi)
                {
                    accent = 1;
                    amp *= 2.0F;
                }
                Debug.Log("Tick: " + accent + "/" + signatureHi);
            }
            phase += amp * 0.3F;
            amp *= 0.993F;
            n++;
        }
    }
}
