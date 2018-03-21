using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour {

    // Use this for initialization
    public Text Page;
    public GameObject PageBG;
    private int PageCount = 0;


    void OnTriggerEnter(Collider collider)
    {
        //Using switch case for many other collectables like health, ammo, and other stuff

        //TODO: Added cases for ammo health packs and many other.
        switch(collider.gameObject.tag)
        {
            case "Page":
                {
                    Debug.Log("Collectables!!");
                    
                    switch(PageCount)
                    {
                        case 0:
                            {
                                //Just disableing not destoying.
                                collider.gameObject.SetActive(false);
                                PageBG.SetActive(true);
                                Page.text = "Welcome to the future town";
                                StartCoroutine(Wait());
                                PageCount++;
                                break;
                            }
                        case 1:
                            {
                                collider.gameObject.SetActive(false);
                                PageBG.SetActive(true);
                                Page.text = "Bla bla bla";
                                StartCoroutine(Wait());
                                PageCount++;
                                break;
                            }
                    }
                    break;
                    
                }
                
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        PageBG.SetActive(false);
    }
}
