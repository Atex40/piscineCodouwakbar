using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class Bonus : MonoBehaviour {

	// Use this for initialization
	private void OnTriggerEnter (Collider other)
    {
        Pawn pawn = other.gameObject.GetComponentInParent<Pawn>();
        if (pawn != null)
        {
            ApplyBonus();
        }
		
	}
	
	// Update is called once per frame
	public void virtual ApplyBonus ()
    {
		
	}
}
