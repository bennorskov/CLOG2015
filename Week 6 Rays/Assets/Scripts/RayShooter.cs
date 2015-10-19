using UnityEngine;
using System.Collections;

public class RayShooter : MonoBehaviour {

	public float rayDistance = 5;


	void Start () {
	}
	
	void Update () {
		RaycastHit hitInfo; // variable to hold information about the raycast
		//if something is rayDistance away from this object from the front
		if ( Physics.Raycast( transform.position, transform.forward, out hitInfo, rayDistance) ) {
			Debug.Log("you've hit the thing named: " + hitInfo.collider.name);
			hitInfo.collider.GetComponent<packTextures>().changeTexture();
		}
	}

	void OnDrawGizmos() {
		//this is only so we can visualize the ray. Gizmos won't show up in the final game
		Gizmos.color = Color.red;
		Gizmos.DrawRay(transform.position, transform.forward * rayDistance);
	}
}
