using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {
	int steps = 0;
	Vector2 homeLocation = new Vector2 (0.0f, 0.0f);
	Vector2 playerLocation = new Vector2 (5.0f, 0.0f);
//	Random rnd = new Random();

	void Start () {
		// randomize the home and player locations
		this.randomLocations ();
		print ("Welcome to Go Home!");
		print ("A game where you need to find your way home.");
		print ("HomeLocation: " + homeLocation.x + ", " + homeLocation.y);
		print ("PlayerLocation: " + playerLocation.x + ", " + playerLocation.y);
	}
		
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			playerLocation.y++;
			moveSteps ();
		}
		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			playerLocation.y--;
			moveSteps ();
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			playerLocation.x--;
			moveSteps ();
		}
		else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			playerLocation.x++;
			moveSteps ();
		}
	}

	float randFloat() {
		return Mathf.Round(Random.value*Random.Range(0, 10));
	}

	void randomLocations() {
		homeLocation.x = this.randFloat();
		homeLocation.y = this.randFloat();

		playerLocation.x = this.randFloat();
		playerLocation.y = this.randFloat();
	}

	void moveSteps() {
		steps++;
		Vector2 distanceV = calculateDistance ();
		float distance = Mathf.Sqrt(Mathf.Pow(distanceV.x, 2) + Mathf.Pow(distanceV.y, 2));
		print ("After " + steps + " steps, you are " + distance + " meter(s) away from home.");
	}

	Vector2 calculateDistance() {
		Vector2 distance = homeLocation - playerLocation;
		return distance;
	}
}
