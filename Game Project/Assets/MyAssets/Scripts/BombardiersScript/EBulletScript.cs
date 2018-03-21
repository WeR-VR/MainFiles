using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBulletScript : MonoBehaviour {


	public Transform player;
	public float range = 50.0f;
	public float bulletStrength= 5.0f;

	private bool onRange= false;

	public Rigidbody projectile;


	// Use this for initialization
	void Start () {


		float rand = Random.Range (5.0f, 8.0f);
		InvokeRepeating("Shoot", 2, rand);
	}
	
	// Update is called once per frame
	void Update () {
		onRange = Vector3.Distance(transform.position, player.position)<range;
		if (onRange){
			//call bullet from object position / facing
			transform.LookAt(player);
		}
	}

	void Shoot(){

		// In range of the player
		if (onRange){
			//call bullet from object position / facing
			Rigidbody bullet = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);


			bullet.AddForce(transform.forward*bulletStrength, ForceMode.Impulse);// bullet force to push bullet
			Destroy (bullet.gameObject, 5); //time/destroy
		}

}
}
