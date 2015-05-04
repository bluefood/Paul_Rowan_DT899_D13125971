using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {

	float maxZoo = 95f;
	float minZoo = 30f;
	float Zoom = 60f;
	float zooSpd = 50f;


	// Use this for initialization
	void Start () {
	
	}

	void Update ()
	{
		Debug.Log(Input.GetAxis("Mouse ScrollWheel"));

		Camera.main.fieldOfView  += Input.GetAxis("Mouse ScrollWheel") * zooSpd;
		Camera.main.fieldOfView = Mathf.Clamp(Zoom, minZoo, maxZoo);
		
		// set camera position
	}

}

	
		                                 


