using UnityEngine;
using System.Collections;

public class zoom : MonoBehaviour {
	public float smooth,normal,zoomed,slowMo;
	public GameObject rotateAroundWhat;


	SteeringBehaviours steerScript2;

	// Use this for initialization
	void Start () 
		{
		steerScript2 = gameObject.GetComponent<SteeringBehaviours>();	
		}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (1)) 
			{
				//Debug.Log("DOWN");
				this.GetComponent<Camera>().fieldOfView =Mathf.Lerp (this.GetComponent<Camera>().fieldOfView, zoomed, smooth * Time.deltaTime);
				Time.timeScale=Mathf.Lerp(Time.timeScale,slowMo,smooth*Time.deltaTime);
			} 
		else
			this.GetComponent<Camera>().fieldOfView =Mathf.Lerp (Camera.main.fieldOfView, normal, smooth * Time.deltaTime);
			Time.timeScale=Mathf.Lerp(Time.timeScale,1,smooth*Time.deltaTime);



		if (Input.GetMouseButton(2))
		
			{
			transform.RotateAround(rotateAroundWhat.transform.position,Vector3.up,Time.deltaTime*22 );
			}
		}
}
