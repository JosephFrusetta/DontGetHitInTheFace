using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Eat : MonoBehaviour {

	public int CupCakeCount;
	public TextMeshPro TextPro;
	public GameObject CCdoor; //Cupcake door
	public TextMeshPro CC10doortxt;
	public GameObject CC10door;
	public TextMeshPro CC7doortxt;
	public GameObject CC7door;
	public TextMeshPro CupcakeWatchText;
	
	public AudioSource source;
    public AudioClip eatSound;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "CupCake")
        {
		Destroy(other.gameObject);
		CupCakeCount += 1;
		CupcakeWatchText.text = CupCakeCount + " cupcakes eaten.";
        }
		if(CupCakeCount == 3)
		{
		CCdoor.GetComponent<Rigidbody>().isKinematic = false;
		TextPro.text = "Door is now open!";
		TextPro.color = new Color32(0, 248, 7, 255);
		}
		if(CupCakeCount == 7)
		{
		CC7door.GetComponent<Rigidbody>().isKinematic = false;
		CC7doortxt.text = "7 cupcakes eaten!";
		CC7doortxt.color = new Color32(0, 248, 7, 255);
		}
		if(CupCakeCount == 10)
		{
		CC10door.GetComponent<Rigidbody>().isKinematic = false;
		CC10doortxt.text = "10 cupcakes eaten!";
		CC10doortxt.color = new Color32(0, 248, 7, 255);
		}
       	if(other.gameObject.CompareTag ("Food"))
        {
		Destroy(other.gameObject);
		source.PlayOneShot (eatSound, 1f);
        }
    }
}
