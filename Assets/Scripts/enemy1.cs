using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public int health;
    public Transform SpawnPoint;
    public GameObject ExitKey;



    private void Update()
    {
      

        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(ExitKey, SpawnPoint.position, SpawnPoint.rotation);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

   

}
