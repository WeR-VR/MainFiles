using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun_raycast : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public GameObject impctEffect;
    private float bullets = 06f;
    public Text BulletText;
    public float Health = 100f;
    public Image HealthBar;

    // Update is called once per frame
    void Update () {
        bullets = Mathf.Clamp(bullets, 0f, Mathf.Infinity);
        BulletText.text = string.Format("{0:00}", bullets);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Reload();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Health--;
            HealthBar.fillAmount = Health / 100f;
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
        bullets = 06f;
    }

    private void Shoot()
    {
        if (bullets > 0)
        {
            muzzleFlash.Play();
            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                Enemy enemy = hit.transform.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.takeDam(damage);
                }

                GameObject imptgameObject = Instantiate(impctEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(imptgameObject, 0.2f);
            }
            bullets--;
        }
        else
        {
            Debug.Log("Reload");
        }
    }
}
