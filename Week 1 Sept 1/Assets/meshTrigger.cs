using UnityEngine;
using System.Collections;

public class meshTrigger : MonoBehaviour {


	void OnTriggerEnter() {
		gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;

		//find the big cube and turn it off
		GameObject.Find ("BigBasketCube").SetActive(false);

		//Destroy(GameObject.Find("BigBasketCube") );
	}

}
