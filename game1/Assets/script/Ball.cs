using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float movespeed = 10f;
	private Rigidbody rbody;
	private Renderer render;
	private Light mylight;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
		render = GetComponent<Renderer> ();
		mylight = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		//move the ball
		float movey=2.5f;
		float inputx=Input.GetAxis ("Horizontal");
		float inputz=Input.GetAxis ("Vertical");
		movey = Input.GetAxis ("Jump");
		float movex = inputx*movespeed*Time.deltaTime;
		float movez = inputz*movespeed*Time.deltaTime;
		//if (Input.GetButtonDown("2")) {
		//movey += movey + 100f;
		//}
		movey-=9.8f*Time.deltaTime;
		rbody.AddForce(movex,movey,movez);

	}

	void OnCollisionEnter(Collision col)
	{
		//print (col.collider.name+"collision");
		if (col.collider.name == "back_wall") {
		
			render.material.color = Color.blue;
			mylight.color = Color.blue;
		}
		if (col.collider.name == "f_wall") {

			render.material.color = Color.red;
			mylight.color = Color.red;
		}
		if (col.collider.name == "lf_wall") {

			render.material.color = Color.green;
			mylight.color = Color.green;
		}
		if (col.collider.name == "r_wall") {

			render.material.color = Color.yellow;
			mylight.color = Color.yellow;
			//Destroy (col.gameObject);
		}
		if (col.collider.name == "Cube") {

			render.material.color = Color.white;
			mylight.color = Color.white;

		}
	}
}
