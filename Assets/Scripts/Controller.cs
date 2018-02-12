using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	public static Controller instance;
	public float ellapsedTime;
	public Text seconds;
	public bool status;


	// Use this for initialization
	void Start () {
		instance = this;
		ellapsedTime = 0;
		status = true;
	}
	
	// Update is called once per frame
	void Update () {
		//Assumes player is alive
		if(status = true){
			ellapsedTime = ellapsedTime + Time.deltaTime;
	}
		//Assumes player is dead
		if(status = false){
			PlayerPrefs.SetFloat ("Highscore", ellapsedTime);
			Load (0);
		}
	}

	public void Load(int val){
		SceneManager.LoadScene (val);
	}
}
