using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingAxisZLongTrick : MonoBehaviour {

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
   	iTween.MoveBy(gameObject, iTween.Hash("z", 12, "easeInOutBo", "easeInOutBounce", "time", 12));
	StartCoroutine(WaitEight());
    }

    void ScanReverse ()
    {
    iTween.MoveBy(gameObject, iTween.Hash("z", -12, "easeType", "linearTween", "time", 12));
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
