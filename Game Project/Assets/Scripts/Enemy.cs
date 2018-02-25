using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float Health = 100f;
    public void takeDam(float amount)
    {
        Health -= amount;
        if (Health<=0f)
        {
            Debug.Log("Death");
        }
    }

}
