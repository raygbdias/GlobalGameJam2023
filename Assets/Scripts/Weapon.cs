using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firepoint;
    public GameObject bulletprefab;

    void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    void Shoot() { 
        Instantiate(bulletprefab, firepoint.position, firepoint.rotation); 
    }
}
