using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerr : MonoBehaviour
{
    public GameObject[] spawners;

    public GameObject enemy;

    [SerializeField] int numOfZombies = 100;

    private void Start(){

        spawners = new GameObject[5];

        for(int i = 0; i< spawners.Length; i++){

            spawners[i] = transform.GetChild(i).gameObject;
        }

        for (int i = 0; i < numOfZombies; i++){
            SpawenEnemy();
        }

    }

    private void Update(){

        if(Input.GetKeyDown(KeyCode.T)){
            SpawenEnemy();
        }

    }

    private void SpawenEnemy(){

        int spawnerId = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[spawnerId].transform.position, spawners[spawnerId].transform.rotation);

    }
}