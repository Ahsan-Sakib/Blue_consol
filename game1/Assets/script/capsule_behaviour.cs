using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule_behaviour : MonoBehaviour {

	public float movespeed;

	void Start () {
		movespeed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		float xaxis = Input.GetAxis ("Horizontal");
		float zaxis = Input.GetAxis("Vertical");
		//print(Input.GetAxis("Horizontal"));
		//print(Input.GetAxis("Vertical"));
		transform.Translate (movespeed*xaxis*Time.deltaTime, 0f,movespeed*zaxis*Time.deltaTime);

	}
}
