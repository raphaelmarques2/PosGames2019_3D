using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet2 : MonoBehaviour
{
    public GameObject bulletMarkPrefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Parede"))
        {
            CreateBulletMark(col);
            Destroy(this.gameObject);
        }
    }

    void CreateBulletMark(Collision col)
    {
        var contact = col.contacts[0];
        
        var newBulletMark = Instantiate(
            bulletMarkPrefab,
            contact.point,
            Quaternion.LookRotation(contact.normal)
            );
    }
}
