﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelManager : MonoBehaviour {

    public static LevelManager Instance { get; private set; }

    public TimeSpan RunningTime { get { return DateTime.UtcNow - _startedTime; } }

    public DateTime _startedTime;
    
	void Awake ()
    {
	    Instance = this;	
	}

    private void Start ()
{
    _startedTime = DateTime.UtcNow;
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
