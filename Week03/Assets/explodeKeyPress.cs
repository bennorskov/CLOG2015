using UnityEngine;
using System.Collections;

public class explodeKeyPress : MonoBehaviour {

	public GameObject explosion;
	
	// Update is called once per frame
	void Update () {


		if ( Input.GetKeyDown( KeyCode.T ) ) {
			Destroy(gameObject);
		}
	}
	void OnDestroy() {
		Debug.Log("this is dead!");
		Instantiate( explosion, transform.position, transform.rotation);
	}
}
