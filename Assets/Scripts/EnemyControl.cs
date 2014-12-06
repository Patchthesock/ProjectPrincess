using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour
{
	void OnCollisionEnter (Collision other)
	{
		if(other.transform.CompareTag("Player"))
			other.transform.GetComponent<PlayerControl>().Die();
	}
}
