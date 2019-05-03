using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseController : MonoBehaviour
{
    public float spellSpeed = 70f;
    public float maxLifeTime = 2f;

    private float lifeTime = 0f;

    private void FixedUpdate()
    {
        lifeTime += Time.deltaTime;
    }

    void Update()
    {
        if(lifeTime >= maxLifeTime)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = transform.forward;

        transform.Translate(direction * Time.deltaTime * spellSpeed, Space.World);
    }
}
