using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public float fireRate = 10f;
    public float damage = 10f;
    public float range = 100f;
    public float impactForce;
    
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    [SerializeField] private float nextTimeToFire;

    // Update is called once per frame
    void Update()
    {
        // Calling the IEnumerator
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Health health = hit.transform.GetComponent<Health>();
            if (health!= null)
            {
                health.TakeDamage(damage);
            }

            if (hit.rigidbody != null )
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
}
