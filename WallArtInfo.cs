using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WallArtInfo : MonoBehaviour {
	
	public TextMeshPro WallArtText;
	private int TouchCount;
	private bool Toggle = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) //If a player's finger continues to touch this object, it will 'retaliate'.
	{
		if(other.gameObject.name == "Index" && TouchCount <= 1 && Toggle == true)
		{
			WallArtText.text = "Not every item can be picked up.";
			Toggle = false;
			StartCoroutine(wait());
		}
		if(other.gameObject.name == "Index" && TouchCount == 2 && Toggle == true)
		{
			WallArtText.text = "Please stop touching me.";
			Toggle = false;
			StartCoroutine(wait());
		}
		if(other.gameObject.name == "Index" && TouchCount == 3 && Toggle == true)
		{
			WallArtText.text = "Stop touching me.";
			Toggle = false;
			StartCoroutine(wait());
		}
		if(other.gameObject.name == "Index" && TouchCount == 4 && Toggle == true)
		{
			WallArtText.text = "Touch me again and you'll really regret it.";
			Toggle = false;
			StartCoroutine(wait());
		}
		if(other.gameObject.name == "Index" && TouchCount == 5 && Toggle == true)
		{
			WallArtText.text = "The game is now 50% more difficult.";
			Toggle = false;
			StartCoroutine(wait());
		}
		if(other.gameObject.name == "Index" && TouchCount >= 6 && Toggle == true)
		{
			WallArtText.text = "I hope you're happy.";
			Toggle = false;
			StartCoroutine(wait());
		}
	}

	IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        WallArtText.text = "";
        TouchCount += 1;
        Toggle = true;
    }
}
