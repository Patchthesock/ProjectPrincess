using UnityEngine;
using System.Collections;

public class ObstacleControl : MonoBehaviour
{
	public float speed = 1.0f;

	void Update ()
	{
		rigidbody.AddForce(-Vector3.right * speed);
		//this.transform.Translate(-Vector3.right * speed);
	}
}
