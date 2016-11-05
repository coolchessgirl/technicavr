using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HRToggle : MonoBehaviour {
	public Toggle reccomended;
	public Toggle moderate;
	public Toggle vigorous;
	public Toggle custom;
	public Button start;
	public InputField minInput;
	public InputField maxInput;
	public static float minHR;
	public static float maxHR;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void RecSelect(){
		if(reccomended.isOn){
		moderate.isOn = false;
		vigorous.isOn = false;
		custom.isOn = false;
			start.interactable = true;
			minHR = Mathf.Round ((220-Next.age)*0.5F);
			maxHR = Mathf.Round ((220-Next.age)*0.85F);
			Debug.Log(minHR + "," + maxHR + "," + Next.age);
		}
		else{
			start.interactable = false;
		}
	}
	public void ModSelect(){
		if(moderate.isOn){
		reccomended.isOn = false;
		vigorous.isOn = false;
		custom.isOn = false;
			start.interactable = true;
			minHR = Mathf.Round ((220-Next.age)*0.5F);
			maxHR = Mathf.Round ((220-Next.age)*0.7F);
			Debug.Log(minHR + "," + maxHR + "," + Next.age);
		}
		else{
			start.interactable = false;
		}
	}
	public void VigSelect(){
		if(vigorous.isOn){
		moderate.isOn = false;
		reccomended.isOn = false;
		custom.isOn = false;
			start.interactable = true;
			minHR = Mathf.Round ((220-Next.age)*0.7F);
			maxHR = Mathf.Round ((220-Next.age)*0.85F);
			Debug.Log(minHR + "," + maxHR + "," + Next.age);
		}
		else{
			start.interactable = false;
		}
	}
	public void CusSelect(){
		if(custom.isOn){
		moderate.isOn = false;
		vigorous.isOn = false;
		reccomended.isOn = false;
			start.interactable = true;
		}
		else{
			start.interactable = false;
		}
	}
	public void StartButton(){
		if(custom.isOn){
		minHR = float.Parse(minInput.text);
		maxHR = float.Parse(maxInput.text);
		}
		Application.LoadLevel("Level1");
	}
}
