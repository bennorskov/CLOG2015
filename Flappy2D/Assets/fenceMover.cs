using UnityEngine;
using System.Collections;

public class fenceMover : MonoBehaviour {

	public float fenceSpeed = 8f;
	
	void Update () {
		transform.position += Vector3.left * fenceSpeed * Time.deltaTime;
	}

	void OnTriggerEnter2D ( Collider2D other) {
		if (other.CompareTag("Player") ) {
			GameObject.Find("ScoreText").GetComponent<scoreKeeper>().addScore();
		}
	}
}
