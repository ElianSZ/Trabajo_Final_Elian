using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject shooter1;
    public GameObject shooter2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(projectilePrefab, shooter1.transform.position, transform.rotation);
        // Instantiate(explosionParticleSystem, shooter1.transform.position, transform.rotation);

        // Se dispara el proyectil 2
        Instantiate(projectilePrefab, shooter2.transform.position, transform.rotation);
        // Instantiate(explosionParticleSystem, shooter2.transform.position, transform.rotation);
    }
}
