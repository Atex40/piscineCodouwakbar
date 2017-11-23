using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBonus : Bonus
{
    public int Shield = 1;

    public override void ApplyBonus(Pawn pawn)
    {
        pawn.AddShield(Shield);
        _animator.SetTrigger("Pickup");
    }
}
