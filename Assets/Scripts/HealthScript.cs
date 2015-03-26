using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int health = 1;
	void Start () {
	}
	
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		Destroy (other.gameObject);Destroy (gameObject);
	}
 	
	void OnTriggerExit2D(Collider2D other){    
	}

	void OnTriggerStay2D(Collider2D other){   
	}
	
	void OnCollisionEnter2D(Collision2D other) {
		
		Destroy (other.gameObject);Destroy (gameObject);
	}
	
	void OnCollisionExit2D(Collision2D other) {
	}
	
	void OnCollisionStay2D(Collision2D other) {
	}
}
