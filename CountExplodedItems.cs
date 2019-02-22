using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountExplodedItems : MonoBehaviour {

  private Transform _myTransform = null;
  private Vector3 _lastPosition;

  private void Awake()
  {
  StartCoroutine(WaitOne());
  	_myTransform = transform;
    _lastPosition  = _myTransform.position;
  }

    IEnumerator WaitOne ()
    {
	yield return new WaitForSeconds(1);
	StartCoroutine(WaitWait());
	if(_lastPosition != _myTransform.position)
   		{
   		gameObject.tag = "LivingRoomActive";
   	    //count tags
   		}
    }

    IEnumerator WaitWait ()
    {
	yield return new WaitForSeconds(2);
	StartCoroutine(WaitOne());
    }
}


