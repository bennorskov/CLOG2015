using UnityEngine;
using System.Collections;

public class destroyAfterParticles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, gameObject.GetComponent<ParticleSystem>().duration);
	}
}
