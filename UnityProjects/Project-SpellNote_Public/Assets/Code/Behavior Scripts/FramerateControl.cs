using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramerateControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log("Current Time: " + Time.time + " | Delta Time: " + Time.deltaTime);
    }
}
