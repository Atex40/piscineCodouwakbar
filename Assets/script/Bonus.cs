using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(AudioSource))]

public abstract class Bonus : MonoBehaviour {

    protected Animator _animator;
    protected AudioSource _audioSource;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter (Collider other)
    {
        Pawn pawn = other.gameObject.GetComponentInParent<Pawn>();
        if (pawn != null)
        {
            _audioSource.pitch = Random.Range(0.8f, 1.25f);
            _audioSource.Play();
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
