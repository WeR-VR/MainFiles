using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleFire : MonoBehaviour {
	public AudioClip Shot;
	public AudioSource audioS;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Shotsound()
	{
		audioS.PlayOneShot (Shot);
	}
}
