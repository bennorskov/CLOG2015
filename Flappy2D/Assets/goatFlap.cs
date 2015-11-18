using UnityEngine;
using System.Collections;

public class goatFlap : MonoBehaviour {

	public float flapForce = 200f;

	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			rb.AddForce( Vector2.up * flapForce );
		}
		//rotation
		float rot = 2 * rb.velocity.y;
		transform.localRotation = Quaternion.Euler( new Vector3( 0, 0, rot));
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (!other.collider.CompareTag("Wall")) {
			showGameOver();
		}
	}
	void showGameOver() {
		Application.LoadLevel(0);
	}
}
