using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/**
* Clase para la cinematica inicial,
* corre en el bosque.
*/

public class cinematicaIni : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("iniciarJuego", 1);
	}

	void iniciarJuego(){
		SceneManager.LoadScene ("PlantaBaja");
	}
}