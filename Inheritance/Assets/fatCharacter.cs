using UnityEngine;
using System.Collections;

public class fatCharacter : CharacterBase {

	public override void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.mass = 200;
		speed = 200f;
		health = 100f;
	}

	void OnCollisionEnter( Collision other ) {
		if (other.gameObject.name != "ground") {
			base.takeDamage( 45f );
			Destroy( other.gameObject);
		}
	}
}
