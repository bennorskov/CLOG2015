using UnityEngine;
using System.Collections;

public class spawnFences : MonoBehaviour {

	public Transform fence;
	public float fenceRandomRange = 2f;

	void Start () {
		InvokeRepeating("spawnFence", 0f, 1f);
	}
	
	void spawnFence () {
		Vector3 startPos = transform.position + Vector3.up * Random.Range(-fenceRandomRange, fenceRandomRange); 
		Instantiate(fence, startPos, Quaternion.identity);
	}
}
