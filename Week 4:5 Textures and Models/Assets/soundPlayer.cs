using UnityEngine;
using System.Collections;

public class soundPlayer : MonoBehaviour {

	private AudioSource explode_sound;	

	void Start () {
		explode_sound = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.G) && explode_sound.isPlaying == false) {
			explode_sound.Play();
		}
	}
}
