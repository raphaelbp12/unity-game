using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float fireRate = 1f;
    public GameObject pulsePrefab;
    public Transform firePoint;
    public float spellSpeed = 10f;

    private float fireCooldown = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fireCooldown <= 0f)
        {
            Shoot();
            fireCooldown = 1f / fireRate;
        }

        fireCooldown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject attackGO = (GameObject)Instantiate(pulsePrefab, firePoint.position, firePoint.rotation);
        PulseController pulse = attackGO.GetComponent<PulseController>();

        if (pulse != null)
        {
            pulse.spellSpeed = spellSpeed;
        }
    }
}
