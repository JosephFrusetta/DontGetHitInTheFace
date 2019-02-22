using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMeshProUpdater : MonoBehaviour 
{
	public TextMeshPro TextPro;
	private float StartTime;
	
	// Use this for initialization
	void Start () 
	{
	StartTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
	float t = Time.time - StartTime;
	string minutes = ((int) t / 60).ToString();
	string seconds = (t % 60).ToString("f2");
	TextPro.text = minutes + ":" + seconds;
	}
}
