using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider))]
public abstract class Bonus : MonoBehaviour {

    protected Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter (Collider other)
    {
        Pawn pawn = other.gameObject.GetComponentInParent<Pawn>();
        if (pawn != null)
        {
            ApplyBonus(pawn);
        }
		
	}
	
	public void DestroyBonus()
    {
        Destroy(gameObject);
    }
	public virtual void ApplyBonus (Pawn pawn)
    {
		
	}
}
