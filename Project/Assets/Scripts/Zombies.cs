using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombies : MonoBehaviour
{
    NavMeshAgent agent;
    float lastAttackTime = 0f;
    float attackCoolDown = 2f;
    GameObject target;

    Animator anim;

    [SerializeField] float stoppingDistance = 3.5f;
    [SerializeField] float damage;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponentInChildren<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(transform.position, target.transform.position);

        if (dist < stoppingDistance){
            StopEnemy(); 
            if (Time.deltaTime - lastAttackTime >=  attackCoolDown){
                lastAttackTime = Time.deltaTime;
            }
        }
        else{
            GoToTarget();
        }
        
    }
    private void GoToTarget(){
        anim.SetBool("isWalking", true);
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
    }

    private void StopEnemy(){
        agent.isStopped = true;
        anim.SetBool("isWalking", false);

    }
}
