using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObjects : MonoBehaviour, ITakeDamage
{
    public float MaxHealth = 100f;
    private float _currentHealth = 0f;

	// Use this for initialization
	void Start ()
    {
        _currentHealth = MaxHealth;
	}

    public void TakeDamage(float damage, GameObject instigator)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
            Kill();
    }

    public void Kill()
    {
        Destroy(this.gameObject);
    }
}
