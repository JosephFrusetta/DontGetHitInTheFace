using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReset : MonoBehaviour {
	public Animator animator;

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {	
	}

	void OnTriggerEnter (Collider other)
	{
	print("HitByKillTagOn..." + other.gameObject.name); //What killed the player?
		if(other.gameObject.tag == "KillPlayer")
		{	
			animator.SetTrigger("FadeOut");	
			StartCoroutine(WaitTillLoad()); //leave time for fade to run && run 
		}
	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name != "Controller (left)" && other.gameObject.name != "Controller (right)"
		&& other.gameObject.name != "Door" && other.gameObject.name != "Door" && other.gameObject.name != "Cupcake"  
		&& other.gameObject.tag != "Food") //These objects cannot kill the player
		{
		print("HitBy..." + other.gameObject.name);
		animator.SetTrigger("FadeOut");		
		StartCoroutine(WaitTillLoad());
		}
	}
	IEnumerator WaitTillLoad ()
    {
	yield return new WaitForSeconds(1);
	Application.LoadLevel("MainScene");
    }
}