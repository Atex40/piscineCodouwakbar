using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineMalus : Bonus {

    public float Damage = 10f;

public override void ApplyBonus (Pawn pawn)
    {
        pawn.TakeDamage(Damage, gameObject);
        Destroy(gameObject);
    }
}
