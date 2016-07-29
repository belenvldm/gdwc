using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class ItemPickUp : MonoBehaviour {

	public Item item;
	public GameObject Game;
	public bool isTaken;
	public string ItemNameTaken;

	void Start()
	{
		ItemNameTaken = item.itemName + ".isTaken";
		if (PlayerPrefs.HasKey (ItemNameTaken)) {
			isTaken = Utils.GetBool (ItemNameTaken);
		} else {
			isTaken = false;
		}
		if (isTaken) {
			gameObject.SetActive (false);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		//GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
		isTaken = true;
		Utils.SetBool (ItemNameTaken, true);
		Destroy(gameObject);
		Game.GetComponent<ItemsManager>().GetItem(item.itemName);
	}

}