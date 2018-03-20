using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour {
	[SerializeField] float rotationSpeed;


	// Update is called once per frame
	void Update () {
		
		transform.Rotate (Vector3.left * rotationSpeed * Time.deltaTime);
 
	}
}
