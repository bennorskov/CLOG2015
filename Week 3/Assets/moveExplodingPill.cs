using UnityEngine;
using System.Collections;

public class moveExplodingPill : MonoBehaviour {

	public float speed = 10f;

	void Update () {
		//move up through scene
		//transform.position = transform.position + a little up
		transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
		// move up at 										  unit[s] 	per second
	}
}
