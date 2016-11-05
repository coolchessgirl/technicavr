using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float speed;
	public float moveTime;
	public bool move = false;
	public float sec = 0;
	public float intsec;
	public float minutes = 0;
	public string seconds;
	public GameObject cam;
	//public float intsec2;
	//public float sec2;
	//public float backsec;
	public float backmin;
	public GameObject tunnel;
	public bool time;
	public Rigidbody player;
	public float rotateSpeed;
	public static int x = 0;

	private bool axisInUse = false;

	//public bool move = true;
	//public string text;

	// Use this for initialization
	void Start () {
		x = 0;
		//backsec = intsec;
		//backmin = minutes;
	}
	IEnumerator Move(){
		yield return new WaitForSeconds(moveTime);
		move = false;
	}
	
	// Update is called once per frame
	void Update () {
			Time.timeScale = 1;
			//transform.Translate (Vector3.forward * Time.deltaTime * speed);
		if(Input.GetKeyDown("space") || Input.GetButton("Fire2")){
			if(axisInUse == false){
			move = true;
			StartCoroutine(Move());
			}
		}
		if(move == true){
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
		}
		//if(Input.GetMouseButton(0)){
		//	transform.Rotate(-transform.up * Time.deltaTime * rotateSpeed);
		//}
		//if(Input.GetMouseButton(1)){
		//	transform.Rotate(transform.up * Time.deltaTime * rotateSpeed);
		//}
		float rotation = Input.GetAxis("Horizontal") * rotateSpeed;
		transform.Rotate(0, rotation, 0);

		//text = num.ToString();
		Timer();

	}

	void Timer(){
		sec = sec + Time.deltaTime;
	//	sec2 = sec2 + Time.deltaTime;
		intsec = Mathf.Round(sec);
		backmin = minutes * 60 + intsec;
	//	intsec2 = Mathf.Round (sec2);

		if (intsec < 10) {
			seconds = "0" + intsec.ToString ();
		} 
		else {
			seconds = intsec.ToString();
		}
		if (intsec >= 60) {
			minutes++;
			sec=0;
		}
		if (backmin % 150 == 0) {
			Vector3 camposition = new Vector3(1,1,0);
			cam.transform.position = camposition;

			//move = false;
		}
	}

	void OnGUI () {

		GUI.Label (new Rect (10, 10, 30, 90), minutes.ToString() + ":" + seconds);
	}

}
//1 mile mark: z axis- 2997.932
//1/4 mile mark: z axis- 893.2895
//6mph = speed 6
//mph = speed
//My idea is to make a track that is 1/4 mile and then send the camera back to the beginning 
//to run the course 3 more times to make a full mile

