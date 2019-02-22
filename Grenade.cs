using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {

	public float delay = 3f;
	public float radius = 1f;
	public float force = 1f; 
	public GameObject explosionEffect;

	float countdown;
	bool hasExploded = false;

	// Use this for initialization
	void Start () 
	{
		countdown = delay;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		 if(other.CompareTag ("ExcludeTeleport"))
		 {
			countdown -= Time.deltaTime;
        	StartCoroutine(AfterHittingFloor());
		 }
	}
	
	IEnumerator AfterHittingFloor()
    {
        yield return new WaitForSeconds(0);
        	if (hasExploded == false)
			{
				Explode();
				hasExploded = true;
			}
    }


	void Explode ()
	{
		Instantiate(explosionEffect, transform.position, transform.rotation);

		Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

		foreach (Collider nearbyObject in colliders)
		{
			Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.AddExplosionForce(force, transform.position, radius);
			}
		}
			Destroy(gameObject);
	}
}
