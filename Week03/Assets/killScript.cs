using UnityEngine;
using System.Collections;

public class killScript : MonoBehaviour {

	void OnTriggerExit( Collider other ) {
		Destroy( other.gameObject );
	}
}
