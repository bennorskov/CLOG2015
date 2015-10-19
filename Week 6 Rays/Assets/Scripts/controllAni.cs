using UnityEngine;
using System.Collections;

public class controllAni : MonoBehaviour {

	Animator animationController;
	void Start () {
		animationController = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) ) {
			animationController.SetInteger("Direction", 0);
		}
		if (Input.GetKey(KeyCode.DownArrow) ) {
			animationController.SetInteger("Direction", 2);
		}
		if (Input.GetKey(KeyCode.LeftArrow) ) {
			animationController.SetInteger("Direction", 3);
		}
		if (Input.GetKey(KeyCode.RightArrow) ) {
			animationController.SetInteger("Direction", 1);
		}
	}
}
