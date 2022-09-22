using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunManager : MonoBehaviour
{
    public float damage = 18;
    public float fireSpeed = 1;
    public Camera cam;
    public float range = 15;
    public GameObject bull;
    public GameObject trace;
    public Transform spawnBull;
    public AudioClip shot;
    public AudioSource audioShot;
    public float force = 100;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootGun();
        }
    }

    public void shootGun()
    {
        audioShot.PlayOneShot(shot);
        Instantiate(trace, spawnBull.position, spawnBull.rotation);
        Instantiate(bull, spawnBull.position, spawnBull.rotation);
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            if(hit.collider != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }
        }
    }
}
