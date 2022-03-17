using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Zombies : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject target;

    [SerializeField] float stoppingDistance = 3.5f;
    [SerializeField] float damage;
    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(transform.position, target.transform.position);

        if (dist < stoppingDistance){
            StopEnemy();
            target.GetComponent<CharacterStats>().TakeDamage(damage);
        }
        else{
            GoToTarget();
        }
        
    }
    private void GoToTarget(){
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
    }

    private void StopEnemy(){
        agent.isStopped = true;
    }
}
