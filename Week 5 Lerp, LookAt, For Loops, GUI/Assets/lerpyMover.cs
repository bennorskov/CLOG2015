using UnityEngine;
using System.Collections;

public class lerpyMover : MonoBehaviour {
	private Transform startPoint, endPoint;
	public float percentage;
	public float speed = 2;

	private int direction;

	// Use this for initialization
	void Start () {
		startPoint = GameObject.Find("StartPoint").transform;
		endPoint = GameObject.Find("EndPoint").transform;
		direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = 
			Vector3.Lerp(startPoint.position, endPoint.position, percentage);

		transform.rotation = Quaternion.Slerp( Quaternion.identity, Quaternion.Euler( new Vector3(-90, 120, 3) ), percentage);

		gameObject.GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.cyan, percentage);

		speed = Mathf.Max(speed, .000001f); //don't divide by zero

		percentage += Time.deltaTime/speed * direction;

		//keep percentage within range
		//switch direction
		if ((percentage>1) || (percentage < 0)) {
			direction = -direction;
			percentage = Mathf.Clamp(percentage, 0, 1);
		}

	}
}











