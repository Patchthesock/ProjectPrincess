using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] obstacles;
	public float spawnRate = 1.0f;

	private float timer = 0.0f;

	void Update ()
	{
		timer += Time.deltaTime;

		if(timer >= spawnRate)
		{
			int random = Random.Range(0, obstacles.Length-1);
			Instantiate(obstacles[random], this.transform.position, this.transform.rotation);
			timer = 0f;
		}
	}
}
