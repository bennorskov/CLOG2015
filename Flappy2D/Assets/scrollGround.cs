using UnityEngine;
using System.Collections;

public class scrollGround : MonoBehaviour {
	Material groundMat;
	private float offset = 0;
	public float offsetSpeed = 1f;
	void Start () {
		groundMat = GetComponent<Renderer>().material;
	}
	
	void Update () {
		offset += offsetSpeed * Time.deltaTime;
		groundMat.SetTextureOffset( "_MainTex", new Vector2(offset, 0));
	}
}
