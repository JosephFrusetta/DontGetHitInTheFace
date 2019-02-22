using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {
	
	public Rigidbody Ammunition;
	public Transform Barrel;
	private bool Recharging = false;

	// Use this for initialization
	void Start () 
	{
		if(Recharging == false)
		{
		StartCoroutine(WaitFive());
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Recharging == false)
		{
		StartCoroutine(WaitFive());
		}
		if(Recharging == true)
		{
		Spawn();
		}

	}

	IEnumerator WaitFive ()
    {
    yield return new WaitForSeconds(5);
    Recharging = true;
    }

	void Spawn ()
	{
	Rigidbody BulletInstance;
	BulletInstance = Instantiate(Ammunition, Barrel.position, Barrel.rotation) as Rigidbody;
	BulletInstance.AddForce(Barrel.forward * 500);
    Recharging = false;
	}
}
