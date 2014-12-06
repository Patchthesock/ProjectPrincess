using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour
{
	public AudioClip[] catSounds;
	public float audioRate;

	private float timer;

	void OnCollisionEnter (Collision other)
	{
		if(other.transform.CompareTag("Player"))
			other.transform.GetComponent<PlayerControl>().Die();
	}

	void Update ()
	{
		timer += Time.deltaTime;

		if(timer >= audioRate)
		{
			PlayRandomAudio();
			timer = 0f;
		}
	}

	void PlayRandomAudio()
	{
		int i = Random.Range(0, catSounds.Length);
		AudioSource.PlayClipAtPoint(catSounds[i], this.transform.position);
	}
}
