using UnityEngine;
using System.Collections;

public class explodeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce( Random.insideUnitSphere * 1000 );
		GetComponent<Rigidbody>().AddTorque( Random.insideUnitSphere * 1000 );
	}

}
