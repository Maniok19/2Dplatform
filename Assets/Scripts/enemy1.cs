using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public int health;
    public GameObject fireball;
    public GameObject ExitKey;
    public Transform enemyshotPoint;
    private float timeBtwShots;
    public float startTimeBtwShots;


    private void Update()
    {
        if (timeBtwShots <= 0)
        {
            
            {
                Instantiate(fireball, enemyshotPoint.position, enemyshotPoint.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(ExitKey, enemyshotPoint.position, enemyshotPoint.rotation);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

   

}
