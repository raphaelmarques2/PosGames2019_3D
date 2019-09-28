using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canhao : MonoBehaviour
{

    public Rigidbody bulletPrefab;
    public float bulletSpeed = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        var newBullet = Instantiate(
            bulletPrefab, 
            this.transform.position, 
            Quaternion.identity);

        newBullet.velocity = this.transform.forward * bulletSpeed;
    }

}
