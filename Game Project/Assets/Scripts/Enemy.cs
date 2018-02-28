using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	[SerializeField] GameObject BulletPrefab;
	[SerializeField] Transform bulletSpawn2;
	[SerializeField] Transform bulletSpawn;

	[SerializeField] float rotationSpeed;


    public float Health = 100f;
    public void takeDam(float amount)
    {
        Health -= amount;
        if (Health<=0f)
        {
            Debug.Log("Death");
			Destroy (gameObject);
        }
    }
	void Update () {

		transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime);

	}

}
