using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour {

	public Transform playerTransform;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print (playerTransform.position.x);
		//float xpoint = Input.GetAxis ("Horizontal")*Time.deltaTime;
		//xpoint *= speed;
		//transform.position=new Vector3(xpoint,0.0f,0.0f);
     if (Mathf.Abs(playerTransform.position.x - transform.position.x) <= 1.03f
			&& Mathf.Abs(playerTransform.position.y - transform.position.y) <= 1.86f
			&& Mathf.Abs(playerTransform.position.z - transform.position.z) <= 1.0f) {

			/*float randX = transform.position.x - Random.Range (-5.0f, 5.0f);
			float randZ = transform.position.z - Random.Range (-4.8f, 5.0f);
			float fixedY = transform.position.y;*/
			float randX =Random.Range (-5.0f, 3.0f);
			float randZ = Random.Range (-4.5f, 4.5f);
			float fixedY = transform.position.y;

             transform.position = new Vector3 (randX, fixedY, randZ);
			print ("Done");
		}
		print ("cube"+transform.position.x);


		//transform.position = new Vector3 (randX, fixedY, randZ);
		//print ("Done");
}
}