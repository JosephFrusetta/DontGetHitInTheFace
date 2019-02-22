using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBounce : MonoBehaviour {

	public TextMeshPro KeyBounceText;
	public GameObject KeySilver;
	public Material Gold;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "KeySilver")
		{
		KeySilver.GetComponent<Renderer>().material = Gold;
		KeyBounceText.text = "You now have a gold key!";	
		KeyBounceText.color = new Color32(0, 248, 7, 255);
		other.gameObject.name = "KeyGold";
		}
	}

}
