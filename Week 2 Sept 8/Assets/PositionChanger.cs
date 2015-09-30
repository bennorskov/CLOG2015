using UnityEngine;
using System.Collections;

public class PositionChanger : MonoBehaviour {
	private float xSpeed = .1f;
	// Use this for initialization
	void Start () {
		Debug.Log (gameObject.transform.position);

	}
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = gameObject.transform.position + new Vector3(xSpeed, .01f, 0);

		//if the position gets too far off screen
		if (gameObject.transform.position.x > 10) {
			xSpeed = -xSpeed;
			//reverse direction
		}
		//same as above but the other direction. 
		if (gameObject.transform.position.x < -10) {
			xSpeed = -xSpeed;
		}
	}
}
