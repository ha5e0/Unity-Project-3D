using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	float rotation = 0.0f;
	float fireCD = 0.0f;

	public float speed = 1.0f;

	public ParticleSystem smoke;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		float hor = 0;
		float ver = 0;
		if (Input.GetKey (KeyCode.A)) {
			hor-=1;
		}
		if (Input.GetKey (KeyCode.D)) {
			hor+=1;
		}
		if (Input.GetKey (KeyCode.W)) {
			ver+=1;
		}
		if (Input.GetKey (KeyCode.S)) {
			ver-=1;
		}

		if (ver!=0 || hor!=0) {
			transform.forward = Vector3.Normalize(new Vector3(hor, 0f, ver));
			transform.Translate(Vector3.forward*Time.deltaTime*speed);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody>().AddForce(new Vector3(0,300.0f,0));
		}

//		if (Input.GetKey (KeyCode.A)) {
//			rigidbody.AddForce(new Vector3(-speed,0,0));
//		}

		Animator anim = GetComponent<Animator>();

		if (Input.GetButton ("Fire1") && fireCD<=Time.time) {
			anim.SetTrigger ("Attack");

			smoke.Emit (1000);
			Rigidbody bul;
			bul = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody;

			fireCD = Time.time + 1.5f;
		}

	}
}
