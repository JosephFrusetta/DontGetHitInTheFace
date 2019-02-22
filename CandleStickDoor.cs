using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleStickDoor : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
	void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.name == "CandleLever")
        {
       	iTween.MoveBy(gameObject, iTween.Hash("x", 1, "easeType", "linearTween", "time", 12));
        }
    }
}
