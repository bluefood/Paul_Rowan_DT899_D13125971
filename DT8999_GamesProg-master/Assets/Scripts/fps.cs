using UnityEngine;
using System.Collections;

public class fps : MonoBehaviour {		// because fps counters	
	public Rect fpsBox;               //box to hold GUI

	public GUIStyle style;
	public float Fps;
	//private TextMesh t;
	public Font font;

		// Use this for initialization
	void Start () 
	{
		style = new GUIStyle();

		fpsBox = new Rect (Screen.width * 0.5f, Screen.height * .905f, 1500, 300);
		style.fontSize=22; //appearance
		style.font = font;


		//t = transform.GetComponent<TextMesh>();
		//t.color = new Color(1,1,1,0.2f);

		//style.font.material = Color.cyan;

		StartCoroutine (RecalcFPS ()); // start fps calc 1/Time.deltatime

	
	}

	private IEnumerator RecalcFPS()  //fps co-routine


	{
		while (true) //always
		{
			  	Fps=1/Time.deltaTime; // inverse of the time between frames
				yield return new WaitForSeconds(1); // stall Fps write
		}

	}



				void OnGUI()//to acecss the string format and style

					{

					//float fps = 1 / Time.deltaTime; 
					//now takn from IEnumera
					GUI.color = new Color(.1f,.8f,1,1f);
					GUI.Label(fpsBox,""+string.Format("{0:0.0}",Fps),style);

					}
	

}
