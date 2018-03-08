using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	private float health = 100;
	public float moveSpeed;
	public Rigidbody playerBody;
	private float maxRot;
	//public int scoreValue = 25;
	//public PlayerScript thePlayer;
	public Transform thePlayer;

	public float smoothTime = 10.0f;
	public float walkingDistance = 10.0f;
	private Vector3 smoothVelocity = Vector3.zero;
	//public AudioSource dead;
	// Use this for initialization
	void Start () {
		
		playerBody = GetComponent<Rigidbody> ();

		//AudioSource dead = GetComponent<AudioSource> ();


	}
	
	// Update is called once per frame
	void fixedUpdate ()
	{
		
	}

	void Update () {
		transform.LookAt (thePlayer);
		float distance = Vector3.Distance(transform.position, thePlayer.position);

		if(distance < walkingDistance)
		{
			transform.position = Vector3.SmoothDamp (transform.position, thePlayer.position, ref smoothVelocity, smoothTime);

		// 1. increment the lookat player(slow turning) 
		// maxRot = transform.LookAt
		// new variable = maxrot/rotspeed
		// transform.rotate by new variable (should be update except top) Start
		// 
		}
	}


		

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bullet") {
			health = health - 5;
			if (health <= 0) {
				//dead.Play ();
				//PlayerScript.score += scoreValue;

				Destroy(this.gameObject);
			}
		}
	}
}


