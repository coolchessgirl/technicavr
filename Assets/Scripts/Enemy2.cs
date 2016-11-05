using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour {

	public RaycastHit hit;
	public GameObject rayObject;
	public GameObject player;
	public float speed;
	public bool move;
	public GameObject score;
	public GameObject scoreText;
	

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("s")){
			Application.LoadLevel("Level2");
		}
		TriggerRay();

		if(move){
		this.transform.LookAt(player.transform.position);
		Vector3 newRotation = this.transform.rotation.eulerAngles;
		newRotation.y += 90.0f;
		this.transform.rotation = Quaternion.Euler (newRotation);
		transform.Translate(Vector3.left * Time.deltaTime * speed);
		}
	
	}
	void TriggerRay(){
		Ray ray = new Ray(rayObject.transform.position, Vector3.forward);
		Debug.DrawLine(ray.origin, hit.point);
		if (Physics.Raycast (ray, out hit)) {
			if(hit.collider.name.Contains("Main Camera")){
				Debug.Log ("hi");
				move = true;
				if(rayObject.name.Contains("4")){
					Application.LoadLevel("Level2");
				}
			}
	}
	}

}
