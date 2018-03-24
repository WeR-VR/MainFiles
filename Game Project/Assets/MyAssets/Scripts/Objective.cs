using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective : MonoBehaviour {

    public GameObject Object;
    public float Time = 3f;

    private void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Show");
            Object.gameObject.SetActive(true);
            StartCoroutine(Wait());
        }
		
	}

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Time);
        Debug.Log("Hide");
        Object.gameObject.SetActive(false);
    }
}
