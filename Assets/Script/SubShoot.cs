using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubShoot : MonoBehaviour {

    public GameObject BulletPrefab;
    public float fireDelay = 0.25f;
    float cooldown = 0;

    AudioSource Shoot;
    void Start()
    {
        Shoot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        cooldown -= Time.deltaTime;
        if (Input.GetButton("Fire1") && cooldown <= 0)
        {
            Shoot.Play();
            Debug.Log("Shoot");
            cooldown = fireDelay;
            Instantiate(BulletPrefab,transform.position,transform.rotation);

           
        }
	}
}
