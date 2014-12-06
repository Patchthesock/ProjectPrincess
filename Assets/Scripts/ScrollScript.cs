using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {

	public float speed;

	void Update ()
	{
		renderer.material.mainTextureOffset = new Vector2(Time.time * speed, 0f);
	}
}
