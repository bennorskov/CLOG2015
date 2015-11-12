using UnityEngine;
using System.Collections;

public class FastCharacter : CharacterBase {

	private Material mat;

	public override void Start () {
		speed = 35f;
		health = 30f;
	}
	void OnCollisionEnter( Collision other ) {
		if (other.gameObject.name != "ground") {
			takeDamage( 20f );
		}
	}
	public override void takeDamage( float damage ) { 
		mat = GetComponent<Renderer>().material;
		mat.color = Color.red;
		Invoke("changeNormal", .2f);
		base.takeDamage ( damage );
	}
	void changeNormal() {
		mat.color = Color.white;
	}
}
