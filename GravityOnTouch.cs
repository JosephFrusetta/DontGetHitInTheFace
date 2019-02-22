using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GravityOnTouch : MonoBehaviour {
	
	public TextMeshPro TouchedCount;
	public TextMeshPro TextPro;
	public TextMeshPro HallwayText;
	public GameObject thing;
	public GameObject LivingRoomDoor;
	public GameObject HallwayDoor;
	
	void Start () {
	AudioSource source = GetComponent<AudioSource>();
	}
	
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Controller (left)" || other.gameObject.name == "Controller (right)")
		{
			if (gameObject.tag != "Food" && gameObject.tag != "Saucers")
			{
			gameObject.tag = "LivingRoomActive"; //If object is moved, give it this tag.
			}
			
			thing.GetComponent<Rigidbody>().useGravity = false;
			GameObject[] LivingRoomLifted = GameObject.FindGameObjectsWithTag("LivingRoomActive"); //Find and count all objects with this tag.
			TouchedCount.text = LivingRoomLifted.Length + " things touched.";	

			if (LivingRoomLifted.Length == 10) //Player touched 10 things and so the living room door is opened.
			{
			LivingRoomDoor.GetComponent<Rigidbody>().isKinematic = false;
			TextPro.text = "Door is now open!";
			TextPro.color = new Color32(0, 248, 7, 255);
			}
			if (LivingRoomLifted.Length >= 30) //Player touched 30 things and so the living room door is opened.
			{
			HallwayDoor.GetComponent<Rigidbody>().isKinematic = false;
			HallwayText.text = "Door is now open!";
			HallwayText.color = new Color32(0, 248, 7, 255);
			}
		}
	}
	void OnCollisionExit(Collision collision)
	{
		thing.GetComponent<Rigidbody>().useGravity = false;					
	}
	void OnTriggerExit(Collider other)
	{
		thing.GetComponent<Rigidbody>().useGravity = false;
	}
}