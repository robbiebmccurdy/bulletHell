using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInteraction : MonoBehaviour
{

    public GameObject hitEffect;

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

   /* void OnCollisionEnter2D(Collision2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        
        if(enemy != null)
        {
            enemy.TakeDamage(40);
        }
        Destroy(gameObject);
    } */
}
