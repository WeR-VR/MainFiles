using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	[SerializeField] float speed;
	[SerializeField] float lifeSpan;
   
    // Use this for initialization

    

    void Start()
    {
		Destroy(gameObject, lifeSpan);
	}
	
	// Update is called once per frame
	void Update()
    {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
   
	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag ("Enemy")) {
			Debug.Log ("HIT!");
			Destroy (gameObject);
		}
	}

}
