using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Script : MonoBehaviour
{
    public int health = 100;
    void Update()
    {
        Vector3 left = Vector3.left;

        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = left * timeSinceLastFrame;

        transform.Translate(translation);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
