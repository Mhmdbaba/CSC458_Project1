using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] spawners;
    public GameObject enemy;
    private void Start()
    {
        spawners = new GameObject[5];

        for (int i = 0; i < spawners.Length; i++){
            spawners[i] = transform.GetChild(i).gameObject;
        }
    }

    private void SpawnEnemy(){
        int spawnerid = Random.Range(0,spawners.Length);
        Instantiate(enemy, spawners[spawnerid].transform.position, spawners[spawnerid].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
            SpawnEnemy();
        }
    }
}