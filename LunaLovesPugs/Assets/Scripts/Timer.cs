using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//https://www.youtube.com/watch?v=x-C95TuQtf0
//Still need to add the end of the game/when the timer should stop
using System;


public class Timer : MonoBehaviour {

	public Text TimerText;
	private float StartTime;
	public Text ScoreText;
	public Text scoreGT;

	// Use this for initialization
	void Start () {
		StartTime = Time.time;

		GameObject scoreGO = GameObject.Find ("ScoreCounter");
		scoreGT = scoreGO.GetComponent<Text> ();
		scoreGT.text = "0";
	}

	// Update is called once per frame
	void Update () {
		float t = Time.time - StartTime;

		string minutes = ((int)t / 60).ToString();
		//If you put in f0 here, it will be just the seconds and minutes.
		string seconds = (t % 60).ToString("f2");

		TimerText.text = "Timer: " + minutes + ":" + seconds;

		double score;//= double.Parse (scoreGT.text);
		//int score = int.Parse (scoreGT.text);
		score = Math.Round((t % 60), 0);
		//score += 100;
		//Mathf.Round(score);

		scoreGT.text = score.ToString ();
		ScoreText.text = "Score: " + score;

		if (score > HighScore.score) {
			HighScore.score = (int)score;
			//HighScore.score = score;
		}
	}
}
