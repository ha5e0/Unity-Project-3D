using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	public float speed = 1;

	
	private Vector3 movement;

	void Start () {
		Destroy(gameObject, 10);
		transform.localPosition.Set(
			transform.localPosition.x+0,
			transform.localPosition.y+0,
			transform.localPosition.z+111.0f
			);
	}
	
	void Update () {
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}
