using UnityEngine;
using System.Collections;

public class ShotAxe: MonoBehaviour 
{
	public float speed;

	void FixedUpdate()
		{
		GetComponent<Rigidbody>().velocity = transform.forward*speed;
		}

	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "Ship") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	}


}