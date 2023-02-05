using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snail_Script : MonoBehaviour
{


    float speed = 1f;
    public int Hitpoints;
    public int MaxHitpoints = 100;
    public SliderBehaviour Healthbar;

    void Start()
    {
        Hitpoints = MaxHitpoints;
    }    
    
    
    
    
    
    
    void Update()
    {
        Vector3 left = Vector3.left;
        float timeSinceLastFrame = Time.deltaTime;
        Vector3 translation = left * timeSinceLastFrame * speed;
        transform.Translate(translation);

     
    }

    public void TakeDamage(int damage)
    {
        Hitpoints -= damage;
        if (Hitpoints <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}


