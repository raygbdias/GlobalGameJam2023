using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform SpawnPoint;
    public GameObject RabbitSpawn;
    public GameObject SnailSpawn;
    public GameObject HumanSpawn;

void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
            Spawn_Rabbit();
            }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Spawn_Human();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Spawn_Snail();
        }
    }

    void Spawn_Rabbit()
    {
        Instantiate(RabbitSpawn, SpawnPoint.position, SpawnPoint.rotation);
    }

    void Spawn_Human()
    {
        Instantiate(HumanSpawn, SpawnPoint.position, SpawnPoint.rotation);
    }

    void Spawn_Snail()
    {
        Instantiate(SnailSpawn, SpawnPoint.position, SpawnPoint.rotation);
    }
}
