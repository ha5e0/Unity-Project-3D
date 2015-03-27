using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int health = 1;
	void Start () {
	}
	
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
	}
 	
	void OnTriggerExit(Collider other){    
	}

	void OnTriggerStay(Collider other){   
	}
	
	void OnCollisionEnter(Collision other) {
		BulletScript obj = other.gameObject.GetComponent<BulletScript>();
		if (obj!=null) {
			health-=1;
			if (health<=0) Destroy (gameObject);
			Destroy (obj.gameObject, 0.1f);
		}
	}
	
	void OnCollisionExit(Collision other) {
	}
	
	void OnCollisionStay(Collision other) {
	}
}
