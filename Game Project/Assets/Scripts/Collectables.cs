using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour {

    // Use this for initialization


    void OnTriggerEnter(Collider collider)
    {
        //Using switch case for many other collectables like health, ammo, and other stuff

        //TODO: Added cases for ammo health packs and many other.
        switch(collider.gameObject.tag)
        {
            case "Page":
                {
                    Debug.Log("Collectables!!");
                    //Just disableing not destoying.
                    collider.gameObject.SetActive(false);

                    break;
                }
                
        }
    }
}
