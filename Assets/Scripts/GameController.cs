using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float timer = 0;
	public float highest = 0;

	void Start ()
	{
		DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(GameObject.FindGameObjectWithTag("Player"))
		{
			timer += Time.deltaTime;

			if(timer > highest)
				highest = timer;
		}
	}
}
