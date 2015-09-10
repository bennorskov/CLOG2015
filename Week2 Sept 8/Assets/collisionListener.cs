using UnityEngine;
using System.Collections;

public class collisionListener : MonoBehaviour {

	void OnTriggerEnter( Collider otherObject ) {}

	void OnCollisionEnter( Collision thisCollision ) {
		if ( thisCollision.gameObject.tag == "Player") {
			print( "Physics Collision" );
		}
	}
}
