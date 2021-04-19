using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : StateMachineBehaviour
{
    public GameObject fireball;
    public GameObject missile;
    public GameObject patrolball;
    public Transform shotPoint;
    private float timeBtwShots;
    public float startTimeBtwShots;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        shotPoint = GameObject.Find("enemyShotPoint").GetComponent<Transform>();
    }

  override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        if (timeBtwShots <= 0)
        {
            Instantiate(fireball, shotPoint.position, shotPoint.rotation);
            timeBtwShots = startTimeBtwShots;
        }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
