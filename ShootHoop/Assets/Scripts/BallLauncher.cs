using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public float ballSpeed = 100.0f;

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody rb = this.getRgBody ();
			Camera camera = GetComponentInChildren<Camera> ();
			rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
		}
	}

	Rigidbody getRgBody() {
		GameObject instance = Instantiate (ballPrefab);
		instance.transform.position = transform.position;
		return instance.GetComponent<Rigidbody> ();
	}
}
