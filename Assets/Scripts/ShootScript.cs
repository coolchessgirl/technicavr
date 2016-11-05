using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour {
	public GameObject sparks;
	public GameObject fire;
	public GameObject dead1;
	public GameObject dead2;
	public GameObject dead3;
	public GameObject dead4;
	public GameObject dead9;
	public GameObject dead10;
	public GameObject dead11;
	public GameObject dead12;
	public GameObject dead13;
	public GameObject dead14;
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
					GameObject newdead1 = (GameObject)Instantiate (dead1, hit.transform.position, hit.transform.rotation);
					GameObject newdead2 = (GameObject)Instantiate (dead2, hit.transform.position, hit.transform.rotation);
					GameObject newdead3 = (GameObject)Instantiate (dead3, hit.transform.position, hit.transform.rotation);
					GameObject newdead4 = (GameObject)Instantiate (dead4, hit.transform.position, hit.transform.rotation);
					GameObject newdead5 = (GameObject)Instantiate (dead9, hit.transform.position, hit.transform.rotation);
					GameObject newdead6 = (GameObject)Instantiate (dead10, hit.transform.position, hit.transform.rotation);
					GameObject newdead7 = (GameObject)Instantiate (dead11, hit.transform.position, hit.transform.rotation);
					GameObject newdead8 = (GameObject)Instantiate (dead12, hit.transform.position, hit.transform.rotation);
					GameObject newdead9 = (GameObject)Instantiate (dead13, hit.transform.position, hit.transform.rotation);
					GameObject newdead10 =(GameObject)Instantiate (dead14, hit.transform.position, hit.transform.rotation);
					Destroy(newdead1, 1.0F);
					Destroy(newdead2, 1.0F);
					Destroy(newdead3, 1.0F);
					Destroy(newdead4, 1.0F);
					Destroy(newdead5, 1.0F);
					Destroy(newdead6, 1.0F);
					Destroy(newdead7, 1.0F);
					Destroy(newdead8, 1.0F);
					Destroy(newdead9, 1.0F);
					Destroy(newdead10, 1.0F);
					}
				}
			}
		}

	}


