using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followShotPoint : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    void Start()
    {
        
    }

  
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
 GameObject.Find("CharacterRobotBoy").transform.position.y,
 transform.position.z);
    }
}
