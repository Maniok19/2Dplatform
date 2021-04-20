using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{

    public float speed;
    public float lifeTime;
    public float distance;
    public LayerMask whatIsSolid;
    public int damage;
    public GameObject destroyEffect;

    private Transform target;
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);


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
