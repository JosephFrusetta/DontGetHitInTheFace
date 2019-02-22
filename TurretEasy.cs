using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurretEasy : MonoBehaviour {
	
	public Rigidbody Ammunition;
	public Transform Barrel;
	public int Speed;
	public int Seconds;
	public bool Recharging = false;

	// Use this for initialization
	void Start () 
	{
	Setup(); 
	}
	// Update is called once per frame
	void Update () 
	{
		if(Recharging == true)
		{
		Recharging = false;
		Spawn();
		Setup();
		}
	}

	void Setup ()
	{
	StartCoroutine(WaitFive());
	}

	IEnumerator WaitFive ()
    {
    yield return new WaitForSeconds(Seconds);
    Recharging = true;
    }

	void Spawn ()
	{
	Rigidbody BulletInstance;
	BulletInstance = Instantiate(Ammunition, Barrel.position, Barrel.rotation) as Rigidbody;
	BulletInstance.AddForce(Barrel.forward * Speed);
	}
}
