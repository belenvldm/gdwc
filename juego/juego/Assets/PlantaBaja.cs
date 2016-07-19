using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/**
* En esta clase va todo lo que sucede en la escena PlantaBaja,
* esto comprende la pb de la casa normal
*/

public class PlantaBaja : MonoBehaviour {
	
	public void OnTriggerEnter (Collider otherCollider) {

		if (otherCollider.gameObject.tag == "Player") {
			
			SceneManager.LoadScene ("MemoriaUno");
		}
	}

	//public void OnSecondFloor() {
		//SceneManager.LoadScene ("SegundoPiso");
	//}
}