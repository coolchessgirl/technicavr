using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Health : MonoBehaviour {
	public Slider healthBarSlider;
	public Text gameOverText;
	public Slider heartRateSlider;
	//public static int heartrateMin;
	//public static int heartrateMax;
	//public Enemy enemyMove;
	//public GameObject enemy;
	

	// Use this for initialization
	void Start () {
		gameOverText.enabled = false;
		Debug.Log (HRToggle.minHR);
		Debug.Log (HRToggle.maxHR);
		if (HRToggle.minHR == 0 && HRToggle.maxHR == 0) {
			Debug.Log ("Hi");
			heartRateSlider.minValue = 92;
			heartRateSlider.maxValue = 183;
		} else {
			heartRateSlider.minValue = HRToggle.minHR - 10;
			heartRateSlider.maxValue = HRToggle.maxHR + 10;
		}
		heartRateSlider.value = (heartRateSlider.minValue + heartRateSlider.maxValue)/2;
		//enemyMove = enemy.gameObject.GetComponent <Enemy> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if(healthBarSlider.value==0){
			gameOverText.enabled = true;
			Time.timeScale= 0;
		}
		if(heartRateSlider.value < heartRateSlider.minValue + 10 || heartRateSlider.value > heartRateSlider.maxValue - 10){
			healthBarSlider.value -= .002f;
		}
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            heartRateSlider.value -= 0.6f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            heartRateSlider.value += 0.6f;
        }
    }
	void OnTriggerStay(Collider other){
		//if player triggers fire object and health is greater than unsafe {
			
		if(other.gameObject.name.Contains("Enemy")){
			healthBarSlider.value -=.002f;  //reduce health
		}
	}

}
