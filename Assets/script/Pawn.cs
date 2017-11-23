using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Pawn : MonoBehaviour, ITakeDamage {

	private Rigidbody _rigidbody;
    public Projectile ProjectilePrefab;
    public Transform SpawnTir;

    protected AudioSource _audioDegats;

    public HUDHandler UiHandler;


    public float MaxSpeed = 100f;
    public float ForwardAcceleration = 25f;


    public float StraffMaxSpeed = 100f;
    public float StraffTime = 0.1f;

    public float MaxHealth = 100f;
    public float CurrentHealth;

    public int Ammo = 3;
    public int Score { get; private set; }

public void Awake () 
	{
        _audioDegats = GetComponent<AudioSource>();
        _rigidbody = GetComponent<Rigidbody>();
		Assert.IsNotNull(_rigidbody);
        Assert.IsNotNull(UiHandler);
        Assert.IsNotNull(_audioDegats);
    }

	void Start () 
	{
        CurrentHealth = MaxHealth;
        Score = 0;

    }

    private void Update ()
    {
        if (Input.GetButtonDown("Fire1") && Ammo > 0)
        {
            SpawnProjectile();
        }
    }
    
    private void SpawnProjectile()
    {
        Projectile projectile = (Projectile)Instantiate(ProjectilePrefab, SpawnTir.position, Quaternion.identity);
        Vector3 initialVelocity = _rigidbody.velocity;
        initialVelocity.x = 0f;
        initialVelocity.y = 0f;
        projectile.Fire(_rigidbody.velocity);
        Ammo--; 
    }


    private float smoothZVelocity = 0f;
    private float smoothXVelocity = 0f;
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
        CurrentHealth = 0;
        LevelManager.Instance.PlayerDeath();
        
    }

    public void TakeDamage(float damage, GameObject instigator)
    {
        _audioDegats.Play();
        CurrentHealth -= damage;
        UiHandler.TakeDamage();
        if (CurrentHealth <= 0)
            Kill();
    }

    public void AddScore(int scoreValue)
    {
        Score += scoreValue;
    }
}
