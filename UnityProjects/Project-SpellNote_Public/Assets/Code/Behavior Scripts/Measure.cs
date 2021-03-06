﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measure : MonoBehaviour
{
    // Public vars
    public Staff staff;
    public float lifespan;

    // Private vars
    private float spawnTime;
    private float deathTime;

    // Start is called before the first frame update
    void Start()
    {
        staff = transform.parent.gameObject.GetComponent<Staff>();
        lifespan = staff.measureLifespan;
        //Debug.Log("Lifespan = " + lifespan);
        spawnTime = Time.time;
        //Debug.Log("Spawn Time = " + spawnTime);
        deathTime = spawnTime + lifespan;
        //Debug.Log("Death Time = " + deathTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(staff.frameDelta);

        if (deathTime <= Time.time)
        {
            Destroy(gameObject);
        }
    }
}

