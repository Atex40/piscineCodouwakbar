using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static LevelManager Instance { get; private set; }

    public TimeSpan RunningTime { get { return DateTime.UtcNow - _startedTime; } }

    public DateTime _startedTime;
    public Pawn Player;
    
	void Awake ()
    {
        Instance = this;
        Assert.IsNotNull(Player);
	}

    private void Start ()
    {
        _startedTime = DateTime.UtcNow;
    }
	
	public void PlayerDeath ()
    {
        CameraController.Instance.currentcamera.transform.parent = null;
        Destroy(Player.gameObject);
    }
}
