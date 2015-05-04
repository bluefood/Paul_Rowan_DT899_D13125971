using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
	Camera cam = Camera.main;
	Vector3 pos;
	public float parallax;
	void Start(){
		pos= new Vector3(0,0,30);
		gameObject.name = "Background";
		GetComponent<Collider>().enabled = false;
		transform.position = pos + cam.transform.position;
		//transform.localScale = new Vector3(20,20,1);
		
	}

	void Update () {
		transform.position = pos + cam.transform.position;
		MeshRenderer mr = GetComponent<MeshRenderer>();
		Material mat = mr.material;
		Vector2 offset = mat.mainTextureOffset;
		mat.mainTextureScale = new Vector2(parallax,parallax);
		offset.x = transform.position.x/20/parallax;
		offset.y = transform.position.y/20/parallax;
		mat.mainTextureOffset = offset;

	}
}
