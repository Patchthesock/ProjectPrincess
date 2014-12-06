using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{	
	// Movement
	public float minDistanceToGround = 0.55f;
	public float jumpForce = 10.0f;

	// Sound
	public AudioClip squeak;
	public AudioClip running;
	public AudioClip dies;

	void Start ()
	{
		AudioSource.PlayClipAtPoint(squeak, this.transform.position);
		AudioSource.PlayClipAtPoint(running, this.transform.position);
	}

	void FixedUpdate ()
	{
		if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
			Movement (Input.GetTouch(0).position);

		if(Input.GetMouseButton(0))
		{
			Movement (Input.mousePosition);
		}
	}

	void Movement (Vector2 newPosition)
	{
		if(CheckOnGround())
			Jump();
	}

	private bool CheckOnGround ()
	{
		Vector3 down = -Vector3.up;
		if(Physics.Raycast(transform.position, down, minDistanceToGround))
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	private void Jump ()
	{
		rigidbody.AddForce(Vector3.up * jumpForce);
	}

	public void Die()
	{
		AudioSource.PlayClipAtPoint(dies, this.transform.position);
		Destroy (this.gameObject);
	}

	public void Boost (float amount)
	{
		this.transform.Translate( Vector3.right * amount );
	}
}
