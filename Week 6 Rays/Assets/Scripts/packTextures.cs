using UnityEngine;
using System.Collections;

public class packTextures : MonoBehaviour {

	public Texture[] textures;
	int currentTexture = 0;

	void Start () {
		GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
	
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			GetComponent<Renderer>().material.mainTexture = textures[0];
		}
	}

	public void changeTexture() {
		currentTexture += 1;
		// the "%" is a modulo operator 
		// it means take the remander after dividing
		currentTexture = currentTexture % textures.Length; 
		GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
	}
}
