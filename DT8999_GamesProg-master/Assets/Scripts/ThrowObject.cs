using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour {
	
	public GameObject projectile;
	public AudioClip shootSound;
	
	
	public float throwSpeed = 2000f;
	private AudioSource source;
	public float volLowRange = .5f;
	public float volHighRange = 1.0f;
	public float timeLimit = 10.0f; // 10 seconds.

	
	void Awake () {
		
		source = GetComponent<AudioSource>();
		
	}

	
	
	void Update () {
		
		if (Input.GetButtonDown("Fire1"))
		{
			float vol = Random.Range (volLowRange, volHighRange);
			source.PlayOneShot(shootSound,vol);
			GameObject throwThis = Instantiate (projectile, transform.position, transform.rotation) as GameObject;
			throwThis.GetComponent<Rigidbody>().AddRelativeForce (new Vector3(0,0,throwSpeed));
		}

	
	}
}
