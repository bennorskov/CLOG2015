using UnityEngine;
using System.Collections;

public class kenMover : MonoBehaviour {

	Animator kenController;
	
	const int ANI_STATE_IDLE = 0;
	const int ANI_STATE_JUMP = 2;
	const int ANI_STATE_DUCK = 1;

	void Start () {
		kenController = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) ){
			kenController.SetInteger("State", ANI_STATE_JUMP);
		} else if ( Input.GetKey(KeyCode.DownArrow) ) {
			kenController.SetInteger("State", ANI_STATE_DUCK);
		} else {
			//play idle animation
			kenController.SetInteger("State", ANI_STATE_IDLE);
		}
	}
}
