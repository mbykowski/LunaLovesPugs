using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//https://www.youtube.com/watch?v=x-C95TuQtf0
public class Timer : MonoBehaviour {

	public Text TimerText;
	private float StartTime;

	// Use this for initialization
	void Start () {
		StartTime = Time.time;
	}

	// Update is called once per frame
	void Update () {
		float t = Time.time - StartTime;

		string minutes = ((int)t / 60).ToString();
		//If you put in f0 here, it will be just the seconds and minutes.
		string seconds = (t % 60).ToString("f2");

		TimerText.text = minutes + ":" + seconds;
	}
}
