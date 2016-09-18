using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncScore(int scorePerHit) {
		score += scorePerHit;
		print ("Ball hit target! Score: " + score);
	}
}
