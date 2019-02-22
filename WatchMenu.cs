using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchMenu : MonoBehaviour {
	
	public GameObject WatchMenuStart;
    private bool collided;
    private bool isActive;

	// Use this for initialization
	void Start () 
    {	
    WatchMenuStart.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {	
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.name == "Controller (right)")
        {
        collided = true; 
        StartCoroutine("HoldForWatch");
        }
	}

    IEnumerator HoldForWatch()
    {
        yield return new WaitForSeconds(3);
        if (collided == true && isActive == false)
        	{
        	print("Touched watch for 3 seconds");
        	// WatchMenuStart.SetActive(true);
        	// isActive = true;
        	// yield return new WaitForSeconds(4);
        	// isActive = false;
        	// WatchMenuStart.SetActive(false);
        	}
    }

    void OnTriggerExit ()
	{
 		collided = false; 
	}

}



