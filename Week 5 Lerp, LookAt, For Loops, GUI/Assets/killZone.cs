using UnityEngine;
using System.Collections;

public class killZone : MonoBehaviour {

	void OnTriggerExit( Collider other) {
		Destroy(other.gameObject);
	}
}
