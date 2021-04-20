using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballs : MonoBehaviour

{
    public float speed;
    public float lifeTime;
    public float distance;
    public Rigidbody2D rb;
    public LayerMask whatIsSolid;
    public int damage;

    public GameObject destroyEffect;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
        //mouvement 
        rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Player"))
            {
                hitInfo.collider.GetComponent<PlayerStats>().PlayerTakeDamage(damage);
            }
            DestroyProjectile();
        }


    }
    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

