using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public GameObject missile;
    public GameObject fireball;
    public Transform enemyshotPoint;
    private float timeBtwShots;
    public float startTimeBtwShots;
    private float timeBtwMissile;
    public float startTimeBtwMissile;


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
        if (timeBtwMissile <= 0)
            {

                {
                    Instantiate(missile, enemyshotPoint.position, enemyshotPoint.rotation);
                    timeBtwMissile = startTimeBtwMissile;
                }
            }
            else
            {
                timeBtwMissile -= Time.deltaTime;
            }

    }
   

   

}
