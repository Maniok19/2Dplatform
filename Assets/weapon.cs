using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotPoint;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public float offset;
  void Update()
    {
        

            if (timeBtwShots <= 0)
            {
                if (Input.GetButton("Fire1"))
                {
                    Instantiate(projectile, shotPoint.position, shotPoint.rotation);
                    timeBtwShots = startTimeBtwShots;
                }
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }


        }
    }

