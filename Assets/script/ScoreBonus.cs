using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBonus : Bonus
{

	public int Score = 50;
    
    public override void ApplyBonus (Pawn pawn)
    {
        pawn.AddScore(Score);
        Destroy(gameObject);
    }

}
