using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

	public int scorePerHit = 1;

	// Use this for initialization
	void Start () {
		print ("Detect Scoring");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		print ("collision!");
		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		scoreKeeper.IncScore (scorePerHit);
	}
}
