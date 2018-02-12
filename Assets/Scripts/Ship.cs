using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {
	private Rigidbody2D rb;
	public GameObject laser;
	public float velocity;
	public float left;
	public float right;
	public Transform laser0;
	public Transform laser1;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		velocity = 4f;
	}
	
	// Update is called once per frame
	void Update () {
		#if UNITY_ANDROID
		float movX = Input.acceleration.x;
		rb.transform.Translate(Vector2.right * velocity * movX *
			Time.deltaTime);
		#endif

	}


	private void OnCollisionEnter2D(Collision2D collision){
		Controller.instance.status = false;
}
}
