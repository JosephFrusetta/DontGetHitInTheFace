using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairFall : MonoBehaviour {
	public GameObject StairBroken;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Thumb")
		{
		Rigidbody rb = StairBroken.AddComponent<Rigidbody>(); 
		}
	}
}
