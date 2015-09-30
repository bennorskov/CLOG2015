using UnityEngine;
using System.Collections;

public class ForcePusher : MonoBehaviour {

	public float xForce;
	public int zTourqe;

	private GameObject redCube;

	// Use this for initialization
	void Start () {
		xForce = 150;
		zTourqe = 230;
		redCube = GameObject.Find("redCube");
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rb = gameObject.GetComponent<Rigidbody>();
		// when i hit the key space, move the object
		// if i hit the space key
		// if ( the Space key is pressed ) {
		if ( Input.GetKey( KeyCode.Space ) == true ) {
			rb.AddForce( new Vector3( xForce, 0, 0 ) );
			rb.AddTorque( new Vector3( 0, 0, 150 ) );
			redCube.transform.localScale = new Vector3 ( 2, 3, 1);
		}
		//Debug.Log(  Input.GetAxis("Horizontal") );
		rb.AddForce( new Vector3( 20, 0, 0) * Input.GetAxis("Horizontal") );
	}
}
