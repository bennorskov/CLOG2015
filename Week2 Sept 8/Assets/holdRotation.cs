using UnityEngine;
using System.Collections;

public class holdRotation : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		gameObject.transform.rotation = Quaternion.identity;	
	}
}
