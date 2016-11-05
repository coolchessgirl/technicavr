using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour {
	public GameObject sparks;
	public GameObject fire;
	public GameObject dead;
	public RawImage crosshair;
	public Text score;
	public static float scoreNum;
	

	// Use this for initialization
	void Start () {
		score.text = scoreNum.ToString();

	}
	IEnumerator crosshairColor(){
		crosshair.color = Color.red;
		yield return new WaitForSeconds(0.2F);
		crosshair.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1")){
			StartCoroutine(crosshairColor());
		}
		Ray ray = new Ray(this.transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 100)) {
			Debug.DrawLine (ray.origin, hit.point, Color.red);
			if(hit.collider.name.Contains("Enemy")){
				if(Input.GetButton("Fire1")){
					scoreNum = scoreNum +1;
					score.text= scoreNum.ToString();
					Destroy(hit.transform.gameObject);
					hit.rigidbody.useGravity = true;
					GameObject newFire = (GameObject)Instantiate (fire, hit.transform.position,Quaternion.identity);
					Destroy (newFire, 0.3F);
					GameObject[] cubes = new GameObject[10];
					for (int x = 0; x < 10; x++) {
						cubes[x] = (GameObject)Instantiate (dead, hit.transform.position, hit.transform.rotation);
					}
					for( int y = 0; y < 10; y++){
						Destroy(cubes[y], 1.0F);
					}
				}
			}
		}
	}

	}


