using UnityEngine;
using System.Collections;

public class pushRandom : MonoBehaviour {

	int pushForce = 500;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody>().AddForce ( Random.insideUnitSphere * pushForce );
		gameObject.GetComponent<Rigidbody>().AddTorque( Random.insideUnitSphere * pushForce );
	}
}
