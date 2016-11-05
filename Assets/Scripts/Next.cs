using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Next : MonoBehaviour {
	public static float age;
	public InputField ageInput;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	public void LoadStartScreen(){
		Application.LoadLevel("StartScreen");
	}
	public void LoadLevel1(){
		age = float.Parse (ageInput.text);
		Application.LoadLevel("ReccomendHR");
	}
}
