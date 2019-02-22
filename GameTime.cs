using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour {
	
	float currCountdownValue;

	// Use this for initialization
	void Start () 
	{
	StartCoroutine(StartCountdown());
	}
	
	// Update is called once per frame
	void Update () {
	}


 	public IEnumerator StartCountdown(float countdownValue = 10)
 	{
	currCountdownValue = countdownValue;
	    while (currCountdownValue > 0)
	    {
	      Debug.Log("Countdown: " + currCountdownValue);
	      yield return new WaitForSeconds(1.0f);
	      currCountdownValue--;
	    }
 	}
}
