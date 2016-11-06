using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour {

	public RaycastHit hit;
	public GameObject ray1;
	public GameObject ray2;
	public GameObject ray3;
	public GameObject ray4;

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
		if(Input.GetKeyDown("r")){
			Application.LoadLevel("Level1");
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
        GameObject[] rayObject = { ray1, ray2, ray3, ray4 };
        for (int i = 0; i < 4; i++) {
			Ray ray = new Ray (rayObject[i].transform.position, Vector3.forward);
			Debug.DrawLine (ray.origin, hit.point);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.name.Contains ("Main")) {
					Debug.Log ("hit");
					move = true;
					if (rayObject[i].name.Contains ("4")) {
						Application.LoadLevel ("Level1");
					}
				}
			}
		}
	}

}
