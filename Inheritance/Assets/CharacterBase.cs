using UnityEngine;
using System.Collections;

public class CharacterBase : MonoBehaviour {

	public float health;
	public float speed;

	public virtual void Start () {
		health = 100f;
		speed = 10f;
	}
	
	// Update is called once per frame
	public void Update () {
		float horz = Input.GetAxis("Horizontal") * speed;
		float vert = Input.GetAxis("Vertical") * speed;
		GetComponent<Rigidbody>().AddForce( new Vector3( horz, 0, vert ) );

		if (Input.GetKeyDown(KeyCode.G) ) {
			takeDamage(1f);
		}
	}

	public virtual void takeDamage( float damage ) {
		health -= damage;

		print("Your Current Health is: " + health);
	}
}
