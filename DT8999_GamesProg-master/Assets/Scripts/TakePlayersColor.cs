using UnityEngine;
using System.Collections;

public class TakePlayersColor : MonoBehaviour {
	public GameObject player;
	public Material myColorMaterial;
	
	// Update is called once per frame
	void Update () {
		if(player.GetComponent<Renderer> ()!=null)
		this.gameObject.GetComponent<Renderer>().material.color =player.GetComponent<Renderer> ().material.color;
	}
}
