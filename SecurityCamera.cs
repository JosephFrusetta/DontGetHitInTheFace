using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour {
	
	public GameObject Camera;
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
	iTween.RotateBy(this.gameObject, iTween.Hash(
	"y", 0.55f,
	"speed", 10f,
	"easeType", iTween.EaseType.easeInOutSine
	));
	StartCoroutine(WaitEight());
    }

    void ScanReverse ()
    {
	iTween.RotateBy(this.gameObject, iTween.Hash(
	"y", -0.55f,
	"speed", 10f,
	"easeType", iTween.EaseType.easeInOutSine
	));
	StartCoroutine(WaitThree());
    }

    IEnumerator WaitEight ()
    {
	yield return new WaitForSeconds(9);
	ScanReverse(); 
    }
    
    IEnumerator WaitThree ()
    {
	yield return new WaitForSeconds(9);
	Scan(); 
    }
    
    void OnCollisionEnter(Collision other)
    {
    Rigidbody rb = Camera.AddComponent<Rigidbody>(); 
    audioSource.Stop();
    }
}
