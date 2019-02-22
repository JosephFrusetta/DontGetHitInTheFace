using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldDoor : MonoBehaviour {
	
	public TextMeshPro Texter;
	public GameObject GoldDoor1;
	public GameObject ThisTrigger;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "KeyGold")
		{
		GoldDoor1.GetComponent<Rigidbody>().isKinematic = false;	
		Destroy (ThisTrigger.gameObject);
		Texter.text = "Door is now open!"; 
		}
		if(other.gameObject.name == "Index")
		{
		Texter.text = "The gold key opens this path";
		}
	}
}
