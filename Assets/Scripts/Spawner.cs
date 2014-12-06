using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] obstacles;
	public float minSpawnRate = 1.0f;
	public float maxSpawnRate = 3.0f;

	private float timer = 0.0f;
	private float actualSpawnRate = 0.0f;

	private float SetSpawnRate()
	{
		return Random.Range(minSpawnRate, maxSpawnRate);
	}

	void Start ()
	{
		actualSpawnRate = SetSpawnRate();
	}

	void Update ()
	{
		timer += Time.deltaTime;
		if(timer >= actualSpawnRate)
		{
			int random = Random.Range(0, obstacles.Length);
			float offsetAngle = Random.Range(0, 45);
			GameObject newObstacle = (GameObject)Instantiate(obstacles[random], this.transform.position, this.transform.rotation*Quaternion.Euler(0,offsetAngle,0));
			Destroy(newObstacle, 5f);
			actualSpawnRate = SetSpawnRate();
			timer = 0f;
		}
	}
}
