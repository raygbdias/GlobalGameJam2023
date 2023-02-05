using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee_Script : MonoBehaviour{
    
    public float speed = 2f;
    public Rigidbody2D rb;
    public int damage = 40;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    { 
        Snail_Script snail = hitInfo.GetComponent<Snail_Script>();
        if (snail != null) { snail.TakeDamage(damage); }

        Rabbit_Script rabbit = hitInfo.GetComponent<Rabbit_Script>();
        if (rabbit != null) { rabbit.TakeDamage(damage); }

        Human_Script human = hitInfo.GetComponent<Human_Script>();
        if (human != null) { human.TakeDamage(damage); }
    }



    void Update() { 
        if (transform.position.x >= 10)
        {
            Destroy(gameObject);
        }   
    }
}

