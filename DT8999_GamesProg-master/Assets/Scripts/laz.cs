using UnityEngine;
using System.Collections;

public class laz : MonoBehaviour {

	LineRenderer line;
	public float pewness;
	SteeringBehaviours steerScript;

	void Start () 
	{
		steerScript = gameObject.GetComponent<SteeringBehaviours> ();
		line = gameObject.GetComponent<LineRenderer> ();
		line.enabled = false;
		Screen.lockCursor = true;

	}
	

	void Update () 
		{
				if (Input.GetButton ("Fire1")) 
				{
						StopCoroutine ("FireLaser");
						StartCoroutine ("FireLaser");

				}
		}

		IEnumerator FireLaser()
		{
			line.enabled=true;

			while(Input.GetButton("Fire1"))

			{


			Ray ray = new Ray(transform.position,steerScript.target.transform.position); //was trans.forw
			RaycastHit hit;
				
				line.SetPosition(0,ray.origin);

//			if(Physics.Raycast(ray, out hit,5000))
//				line.SetPosition(1,hit.point);
						
//			if(hit.rigidbody)							
//			  			 {
//							Debug.Log ("lasHit");
//
//
//							}
				//steerScript.velocity*=3f;
					
				if(steerScript.target.GetComponent<Rigidbody>()==null){
				steerScript.target.AddComponent<Rigidbody>();
				//steerScript.target.GetComponent<Rigidbody>().useGravity=false;
				steerScript.target.GetComponent<Rigidbody>().AddExplosionForce(500,steerScript.target.transform.position,50);
			}
				line.SetPosition(1,steerScript.target.transform.position);
				steerScript.fleeEnabled = true;
				yield return null;


			}
			line.enabled=false;
		Rigidbody targetRigidbody=steerScript.target.GetComponent<Rigidbody> ();
		Destroy (targetRigidbody);
			
		}
}
