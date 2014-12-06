using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float Spin = 50;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, 0, Spin) * Time.deltaTime);
	}
}
