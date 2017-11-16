using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text Scoring;
    private float score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {

        AddScore();
	}

    void AddScore()
    {
        score += Time.deltaTime * 10;
        AffichageScore();
    }

    void AffichageScore()
    {
        Scoring.text = score.ToString("F0");
    }
}
