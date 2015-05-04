using UnityEngine;
using System.Collections;

public class par3nt : MonoBehaviour {


	GameObject playr;
	GameObject Spot;

	// Use this for initialization
	void Start () {
		//if(playr) 
		Spot = GameObject.Find ("spot");
		playr  = GameObject.Find ("player");
		playr.transform.parent = Spot.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
