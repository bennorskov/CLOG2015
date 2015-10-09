using UnityEngine;
using System.Collections;
using UnityEngine.UI; //import in Unity's UI elements so we can make a Slider variable

public class spawnCubes : MonoBehaviour {

	public GameObject cubeToSpawn;
	public Slider cubeSliderCounter;

	public string[] names = { "gertrude", "billy", "trump", "crunchy", "milk", "anything" };

	public void makeCubes() {
		Debug.Log("button was pressed!");

		//value is a float
		//you can't stick a float into an int; use Mathf functions to convert
		int numCubes = Mathf.RoundToInt( cubeSliderCounter.value );

		//where to start = 0
		//count until you reach = numCubes
		//count by = 1

		for ( int count = 0; count < numCubes; count = count + 1 ) {
			GameObject justSpawnedCube = Instantiate(cubeToSpawn, Random.insideUnitSphere * 10f, Quaternion.identity) as GameObject;
			justSpawnedCube.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * 100);

			//pick a random name based on the number of strings in the array "names"
			// names.Length is set to however many names there are
			// Random.Range(0, names.Lenth) = a number between 0 and 7 (but only because i added a name in the editor)
			//adding another won't break it
			justSpawnedCube.GetComponentInChildren<Text>().text = names[ Random.Range(0, names.Length) ];
		}
	}
}




