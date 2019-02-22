using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BottlesGone : MonoBehaviour {
	
	public int count;
	public GameObject BottleDoor;
	public TextMeshPro BottleDoorText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider other)
	{
		if(other.CompareTag ("Battery"))
		{
			count += 1;
		}
		if(other.CompareTag ("Saucers"))
		{
			count -= 1;
		}
		if(count > 3)
		{
			BottleDoor.GetComponent<Rigidbody>().isKinematic = false;	 	
			BottleDoorText.text = "The door is open!";	
			BottleDoorText.color = new Color32(0, 248, 7, 255);
		}
	}
}