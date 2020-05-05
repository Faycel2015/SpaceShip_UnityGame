using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Enemy : MonoBehaviour
{

    public GameObject enemy;

    float TimeRand = 1f;
    void Start()
    {
        InvokeRepeating("AddEnemy", TimeRand, TimeRand);
    }

   
    void Update()
    {
        
    }

    void AddEnemy() {

        TimeRand = Random.Range(1f, 3f);
        Instantiate(enemy, transform.position, transform.rotation);

    }
}
