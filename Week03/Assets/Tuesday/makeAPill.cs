using UnityEngine;
using System.Collections;

public class makeAPill : MonoBehaviour {

	public GameObject pillToSpawn;
	
	// Update is called once per frame
	void Update () {
		//if I press the G key
		if ( Input.GetKeyDown ( KeyCode.G ) ) {
			//spawn pill
			//Instantiate( GameObject, Vector3 position, Quaternion rotation);
			Instantiate( pillToSpawn, transform.position, transform.rotation );
		}
	}
}
