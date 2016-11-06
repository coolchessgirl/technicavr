using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public RaycastHit hit;
	public static bool didHit;
	public static bool didHit2;
	private bool[] hitArray = new bool[3];
	public bool increase;
	public bool restart;
	public GameObject healthBar;


	// Use this for initialization
	void Start () {
		Debug.Log ("start");
		increase = true;
		didHit = false;
		didHit2 = false;
		restart = false;

	}
	
	// Update is called once per frame
	void Update () {
		didHit = hitArray[0];
		didHit2 = hitArray[1];
		restart = hitArray[2];
		Ray ray = new Ray(this.transform.position, Vector3.forward);
		Debug.DrawLine(ray.origin, hit.point);
		if (Physics.Raycast (ray, out hit)) {
			if(hit.collider.name.Contains("Main Camera") && increase){
				Debug.Log (this.gameObject);
				hitArray[CameraMove.x] = true;
				CameraMove.x++;
				increase = false;
				    }
			}
		if(restart){
			Application.LoadLevel("Level1");
		}

		}

	}

