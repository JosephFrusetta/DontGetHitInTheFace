using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChestCellPhone : MonoBehaviour {
	
	public int count;
	public TextMeshPro ChestDoorText;
	public GameObject ChestDoor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag ("Saucers")) //Saucers is the tag for special items, like cell phones in this case.
		{
		count += 1;
		other.GetComponent<Rigidbody>().useGravity = true;
		}
		if(count == 3)
		{
		ChestDoor.GetComponent<Rigidbody>().isKinematic = false;
		ChestDoorText.text = "The Door is open!";
		ChestDoorText.color = new Color32(0, 248, 7, 255);
		}
	}

	void OnTriggerExit(Collider other)
	{
		 if(other.CompareTag ("Saucers"))
		 {
		 count -= 1;
		 }
	}
}

