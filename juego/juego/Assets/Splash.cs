using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/**
* En esta clase va todo lo correspondiente al splash (index) del juego,
* aca iria el logo y un boton "play" o un loading... 
*/

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("onLoad", 2);
	}

	void onLoad(){
		//Application.LoadLevel ("PlantaBaja");
		SceneManager.LoadScene("cinematicaIni");
	}
}