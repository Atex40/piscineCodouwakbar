using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Assertions;

public class LevelManager : MonoBehaviour {

    public static LevelManager Instance { get; private set; }

    public TimeSpan RunningTime { get { return DateTime.UtcNow - _startedTime; } }

    public DateTime _startedTime;
    public Pawn Player;
    
	void Awake ()
    {
        Instance = this;
        Assert.IsNitNull(Player);
	}

    private void Start ()
    {
        _startedTime = DateTime.UtcNow;
    }
	
	void PlayerDeath ()
    {
        Player.Camera.transform.parent = null;
        Destroy(Player.gameObject);
	}
}
