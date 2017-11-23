using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

[RequireComponent(typeof(Animator))]
public class HUDHandler : MonoBehaviour
{

    [Header("Game")]
    public Pawn Player;

    [Header("Interface")]
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI AmmoText;
    public TextMeshProUGUI ShieldText;
    public Image HealthBar;

    [Header("Settings")]
    public float ScoreIncrementSpeed = 10f;

    private Animator _animator;
    private int _currentScore;
    
    void Awake ()
    {
        Assert.IsNotNull(Player);
        Assert.IsNotNull(ScoreText);
        Assert.IsNotNull(AmmoText);
        Assert.IsNotNull(ShieldText);
        Assert.IsNotNull(HealthBar);
        _currentScore = 0;

        _animator = GetComponent<Animator>();
    }
		
	void Update ()
    {
	    if(Player != null)
        {
            AmmoText.text = "" + Player.Ammo;
            ShieldText.text = "" + Player.CurrentShield;
            HealthBar.fillAmount = Mathf.Max(0, Player.CurrentHealth / Player.MaxHealth);
            if (HealthBar.fillAmount >= 0.8f)
            {
                HealthBar.color = new Color(0,255,0);
            }
            else if(HealthBar.fillAmount >= 0.4f)
            {
                HealthBar.color = new Color(255,100,0);
            }
            else
            {
                HealthBar.color = new Color(255,0,0);
            }

            if(Player.Score > _currentScore)
            {
                _currentScore += Mathf.RoundToInt(Time.deltaTime * ScoreIncrementSpeed);
                if(_currentScore > Player.Score)
                   _currentScore = Player.Score;
                
            }
            else if(Player.Score < _currentScore)
            {
                _currentScore += Mathf.RoundToInt(Time.deltaTime * ScoreIncrementSpeed);
                if (_currentScore < Player.Score)
                    _currentScore = Player.Score;
            }
            ScoreText.text = _currentScore.ToString();

        }	
	}
 
    public void TakeDamage ()
    {
    //    _animator.SetTrigger("TakeDamage");
    }
}
