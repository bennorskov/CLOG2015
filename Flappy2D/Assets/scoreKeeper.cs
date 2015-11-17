using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreKeeper : MonoBehaviour {

	private int score;

	void Start () {
		score = -1;
		addScore();
	}
	
	public void addScore () {
		score++;
		GetComponent<Text>().text = score.ToString();
	}
}
