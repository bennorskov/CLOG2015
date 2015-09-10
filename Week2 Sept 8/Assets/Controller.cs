using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey("a") == true ) {
			gameObject.GetComponent<Rigidbody>().AddTorque(Vector3.forward * 10);
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * 100);
		}
		if ( Input.GetKey("s") == true ) {
			gameObject.GetComponent<Rigidbody>().Sleep();
		}
	}
}
