using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int Playerhealth;
   
    void Update()
    {

        if (Playerhealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }

    public void PlayerTakeDamage(int damage)
    {
        Debug.Log("Damage)");
        Playerhealth -= damage;
    }
}

