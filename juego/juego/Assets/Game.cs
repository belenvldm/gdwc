using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.DeleteAll ();
		Events.OnGetItem += OnGetItem;
	}
	
	void OnGetItem(string itemName)
	{
		print ("Agarre un: " + itemName);
	}
}
