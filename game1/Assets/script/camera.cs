using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
	public Transform ball;
	public int forward=1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float posx = ball.position.x;
		float posy = ball.position.y;
		float posz = ball.position.z;

		if (posz < -3.00f && forward == 1) {
			//posz += -2.00f;
			//posx += .38f;
			posx = 0f;
			posy = 2.5f;
			posz = 1.8f;
			//Vector3 rotate=	new Vector3 (180f,0f,180f);
		    this.transform.Rotate (3.14f, 0f, 3.14f); 
			//this.transform.Rotate (180f, 0f, 180f); 
			forward = 0;
			Vector3 pos = new Vector3 (posx, posy, posz);
			transform.position = pos;
		} 


		else if (transform.position.z == 1.8) {
		}
		else if(transform.position.z<1.8) {
			posz = -5.2f;
			posx+=0f;
			Vector3 pos = new Vector3 (posx, posy, posz);
			transform.position = pos;

		}


	}
}
