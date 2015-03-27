using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int health = 1;
	void Start () {
	}
	
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		
		//Destroy (other.gameObject);
		//Destroy (gameObject);
	}
 	
	void OnTriggerExit(Collider other){    
	}

	void OnTriggerStay(Collider other){   
	}
	
	void OnCollisionEnter(Collision other) {
		//BulletScript buls = other.
		//Destroy (other.gameObject);
		//Destroy (gameObject);
	}
	
	void OnCollisionExit(Collision other) {
	}
	
	void OnCollisionStay(Collision other) {
	}
}
