using UnityEngine;
using System.Collections;

public class heyLook : MonoBehaviour {

	Transform lerpysPosition;

	// Use this for initialization
	void Start () {
		lerpysPosition = GameObject.Find("Lerpy").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(lerpysPosition.position);
		transform.position += Time.deltaTime * transform.forward;
	}	
}
