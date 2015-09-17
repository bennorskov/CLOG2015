using UnityEngine;
using System.Collections;

public class killOtherObject : MonoBehaviour {

	void OnTriggerExit( Collider otherObject ) {
		//only destroy prefabs tagged with pills
		//prefabs are tagged with "pills"
		//if it has the tag "pills"
		if (otherObject.gameObject.tag == "pills") {
			Destroy( otherObject.gameObject );
		}
		Debug.Log("trigger exit!");
	}
}
