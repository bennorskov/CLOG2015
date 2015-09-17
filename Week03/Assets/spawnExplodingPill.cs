using UnityEngine;
using System.Collections;

public class spawnExplodingPill : MonoBehaviour {

	public GameObject expPill;
	private bool canShoot;

	// Use this for initialization
	void Start () {
		canShoot = true;
		InvokeRepeating("shootAuto", .3f, 1.5f);
	}

	void shootAuto() {
		Instantiate(expPill, transform.position, transform.rotation);
	}

	void spawnAPill() {
		Instantiate(expPill, transform.position, transform.rotation);
		canShoot = false;
		Invoke( "turnOnShooter", .5f);
	}

	void turnOnShooter() {
		canShoot = true;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (canShoot == true) {
				spawnAPill();
			}
		}
	}
}
