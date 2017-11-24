using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(AudioSource))]

public abstract class Bonus : MonoBehaviour {

    
    protected AudioSource _audioSource;

    private void Awake()
    {
       
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
