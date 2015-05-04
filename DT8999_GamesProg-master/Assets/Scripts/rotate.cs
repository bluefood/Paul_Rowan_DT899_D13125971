using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public float degrees,rotationSpeed;
	// Use this for initialization
	void Start () {
		//rotationSpeed = Random.Range (40, 60);
	}
	
	// Update is called once per frame
	void Update () {
		degrees = Mathf.LerpAngle (degrees, degrees + rotationSpeed, rotationSpeed*Time.deltaTime);
		transform.eulerAngles= new Vector3 (transform.rotation.x,degrees,transform.rotation.z);

	}
}
