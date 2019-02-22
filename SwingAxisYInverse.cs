using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingAxisYInverse : MonoBehaviour {

public AudioSource audioSource;

	// Use this for initialization
	void Start () {
	Scan();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Scan ()
    {
   	iTween.MoveBy(gameObject, iTween.Hash("z", -2, "easeType", "linearTween", "time", 8));
	StartCoroutine(WaitEight());
    }

    void ScanReverse ()
    {
    iTween.MoveBy(gameObject, iTween.Hash("z", 2, "easeType", "linearTween", "time", 8));
    StartCoroutine(WaitThree());
    }

    IEnumerator WaitEight ()
    {
	yield return new WaitForSeconds(4);
	ScanReverse(); 
    }
    
    IEnumerator WaitThree ()
    {
	yield return new WaitForSeconds(4);
	Scan(); 
	}
}
