using UnityEngine;
using System.Collections;

public class testRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
	
	}
}
