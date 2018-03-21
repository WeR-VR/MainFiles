using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour {
	public GameObject BulletPrefab;
	public GameObject BulletPrefab2;
	public Transform SpreadSpawn;
    public Transform SpreadSpawn2;
    public Transform SpreadSpawn3;
    public Transform SpreadSpawn4;
    public Transform bulletSpawn;

    public  float   damage = 15f;
	public  float   burstdamage =30f;
    public  float   range = 100f;
    private float   bullets = 10f;
    public  Text    BulletText;
    public  float   Health = 100f;
    public  Camera  fpscam;
    public  Image   HealthBar;



    // Update is called once per frame
    void Update()
    {
        bullets = Mathf.Clamp(bullets, 0f, Mathf.Infinity);
        BulletText.text = string.Format("{0:00}", bullets);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Burstshot();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Health--;
            HealthBar.fillAmount = Health/100f;
        }
        if (bullets == 0)
        {
            BulletText.color = Color.red;
            BulletText.text = "Reload";
        }
    }

    private void Reload()
    {
        Debug.Log("Reloading");
        //TODO: Add Delay Function
        Debug.Log("Reloading Complete!");
        //TODO: Add Delay Function
        BulletText.color = Color.cyan;
        bullets = 10f;
    }

    private void Shoot()
    {
        if (bullets > 0)
        {
            Instantiate(BulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            RaycastHit hit;
            if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                Enemy enemy = hit.transform.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.takeDam(damage);
                }
            }
            bullets--;
        }
        else
        {
            Debug.Log("Reload");
        }
    }
    private void Burstshot()
    {
        if (bullets >= 5)
        {
            Instantiate(BulletPrefab2, bulletSpawn.position, bulletSpawn.rotation);
            Instantiate(BulletPrefab2, SpreadSpawn.position, SpreadSpawn.rotation);
            Instantiate(BulletPrefab2, SpreadSpawn2.position, SpreadSpawn2.rotation);
            Instantiate(BulletPrefab2, SpreadSpawn3.position, SpreadSpawn3.rotation);
            Instantiate(BulletPrefab2, SpreadSpawn4.position, SpreadSpawn4.rotation);
            RaycastHit hit;
            if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                Enemy enemy = hit.transform.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.takeDam(burstdamage);
                }
            }
            bullets -= 5;
        }
        else
        {
            Debug.Log("Cant Use Burst!\n Reload!");
        }
    }
}
