using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBonus : Bonus
{
    private bool destroy = false;
	public int Score = 50;
    
    public override void ApplyBonus (Pawn pawn)
    {
        pawn.AddScore(Score);
        _animator.SetTrigger("Pickup");
        destroy = true;
        if (destroy == true)
        {
           Destroy(gameObject);
        }
    }

    
}
