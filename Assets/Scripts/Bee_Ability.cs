using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform SpawnPoint;
    public GameObject BeeSpawn;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Ability_Bee();
        }
    }


    void Ability_Bee() { 
        Instantiate(BeeSpawn, SpawnPoint.position, SpawnPoint.rotation); 
    }
}
