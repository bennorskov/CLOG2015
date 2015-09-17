using UnityEngine;
using System.Collections;

public class pillShooterMover : MonoBehaviour {

	public float speed = 10;
	// Update is called once per frame
	void Update () {
		// where you are plus an offset amount
		// transform.position + (input amount)
		//transform.position = transform.position + direction * speed * per second;
		transform.position = transform.position + new Vector3 (Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0 ,0);

		//Debug.Log( new Vector3 (Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0 ,0) );
	}
}
