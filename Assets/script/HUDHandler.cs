using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class HUDHandler : MonoBehaviour
{


    [Header("Game")]
    public Pawn Player;

    [Header("Interface")]
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI AmmoText;
    public Image HealtBar;
    // Use this for initialization
    void Awake ()
    {
        Assert.IsNotNull(Player);
        Assert.IsNotNull(ScoreText);
        Assert.IsNotNull(AmmoText);
        Assert.IsNotNull(HealtBar);

    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(Player != null)
        {
            AmmoText.text = "x " + Player.Ammo;
            HealtBar.fillAmount = Mathf.Max(0, Player.CurrentHealth / Player.MaxHealth);
            if (HealtBar.fillAmount >= 0.8f)
            {
                HealtBar.color = new Color(0,255,0);
            }
            else if(HealtBar.fillAmount >= 0.4f)
            {
                HealtBar.color = new Color(255,100,0);
            }
            else
            {
                HealtBar.color = new Color(255,0,0);
            }

            ScoreText.text = Player.Score.ToString();

        }	
	}
}
