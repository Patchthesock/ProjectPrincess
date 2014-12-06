using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{	
	public float minDistanceToGround = 0.55f;
	public float jumpForce = 10.0f;

	private float extraForce = 1.0f;

	void Update ()
	{

		if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
			Movement (Input.GetTouch(0).position);

		if(Input.GetMouseButton(0))
		{
			while(Input.GetMouseButtonDown(0))
			{
				extraForce += Time.deltaTime;

				if(extraForce >= 1.4f)
					break;
			}
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
		Vector3 down = transform.TransformDirection(-Vector3.up);
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
		Debug.Log(extraForce.ToString());
		rigidbody.AddForce(Vector3.up * jumpForce * extraForce);
		extraForce = 1.0f;
	}

	public void Die()
	{
		Destroy (this.gameObject);
	}

	public void Boost (float amount)
	{
		this.transform.Translate( Vector3.right * amount );
	}
}
