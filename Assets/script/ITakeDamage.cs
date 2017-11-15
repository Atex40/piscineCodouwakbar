using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ITakeDamage
{
    void TakeDamage(float damage, GameObject instigator);
}
