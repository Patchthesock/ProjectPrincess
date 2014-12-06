using UnityEngine;
using System.Collections;

public class DistancePickUp : MonoBehaviour
{
	public float boost = 1.0f;

	void OnCollisionEnter (Collision other)
	{
		if(other.transform.CompareTag("Player"))
		{
			Destroy(this.gameObject);
			other.transform.GetComponent<PlayerControl>().Boost(boost);
		}
	}
}
