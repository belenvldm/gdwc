using UnityEngine;
using System.Collections;

public class Data : MonoBehaviour {

	static Data mInstance = null;
	public Inventory inventory;

	public static Data Instance
	{
		get
		{
			if (mInstance == null) 
			{
				Debug.LogError ("Algo llama a DATA antes de inicializarse");
			}
			return mInstance;
		}
	}

	void Awake()
	{
		mInstance = this;
		DontDestroyOnLoad (this);
		inventory = GetComponent<Inventory> ();
	}
}