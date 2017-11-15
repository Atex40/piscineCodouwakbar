using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerManager : MonoBehaviour {

	private Rigidbody _rigidbody;

	public float MaxSpeed = 100f;
    public float ForwardAcceleration = 25f;


    public float StraffMaxSpeed = 100f;
    public float StraffTime = 0.1f;

    public float _currentHealth = 3;

	public void Awake () 
	{
		_rigidbody = GetComponent<Rigidbody>();
		Assert.IsNotNull(_rigidbody);
	}

	void Start () 
	{

	}
	
	private float smoothXVelocity;
	void FixedUpdate () 
	{
		Mouvement();
	}

	void Mouvement () 
	{
		Vector3 newVelocity = _rigidbody.velocity;
		if(newVelocity.z > MaxSpeed)
		{
			newVelocity.z = MaxSpeed;
		}
		else
		{
			newVelocity.z += ForwardAcceleration * Time.fixedDeltaTime;
		}

		float targetVelocity = Input.GetAxis("Horizontal") * StraffMaxSpeed;
		newVelocity.x = Mathf.SmoothDamp(newVelocity.x, targetVelocity, ref smoothXVelocity, StraffTime);

		_rigidbody.velocity = newVelocity;
	}

	private void LateUpdate () 
	{
		Debug.Log(_rigidbody.velocity.z);
	}

    public void Kill()
    {
        _currentHealth = 0;
        LevelManager.Instance.PlayerDeath();
        
    }
}
