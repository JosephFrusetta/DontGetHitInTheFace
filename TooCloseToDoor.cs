using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooCloseToDoor : MonoBehaviour {

	public GameObject Grenade1;
	public GameObject Grenade2;
	public GameObject Grenade3;
	public TextMeshPro GrenadeDoorText;
	public GameObject GrenadeDoor;

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
		Grenade1.GetComponent<Rigidbody>().useGravity = true;
		Grenade2.GetComponent<Rigidbody>().useGravity = true;
		Grenade3.GetComponent<Rigidbody>().useGravity = true;
		GrenadeDoorText.text = "Grenades deployed";
        StartCoroutine(WaitingForExplosion());
		}
	}
	 IEnumerator WaitingForExplosion()
    {
    yield return new WaitForSeconds(6);
    GrenadeDoorText.text = "Door Open!";
    GrenadeDoorText.color = new Color32(0, 248, 7, 255);
    GrenadeDoor.GetComponent<Rigidbody>().isKinematic = false;
    }
}
