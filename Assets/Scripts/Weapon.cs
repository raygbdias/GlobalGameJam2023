using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee_Ability : MonoBehaviour {

    public Transform firepoint;
    public GameObject bulletprefab;

    void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            Ability_Bee();
        }
    }


    void Ability_Bee() { 
        Instantiate(bulletprefab, firepoint.position, firepoint.rotation); 
    }
}
