using UnityEngine;
using System.Collections;

public class clickCat : MonoBehaviour {
	public int catID;
	void OnMouseDown() {
		SendMessageUpwards("rotate", catID );
	}
	void Update() {
		//to keep the cat's head pointed skyward. 
		transform.rotation = Quaternion.identity;
	}
}
