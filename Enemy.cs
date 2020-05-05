using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public GameObject Explosion;
    public float speed = 1.5f;
    void Start()
    {
        speed = Random.Range(1.5f, 3.5f);

        float posx = Random.Range(-1.8f, 1.8f);
        transform.position = new Vector2(transform.position.x + posx, transform.position.y);
    }

   
    void Update()
    {
        transform.position = new Vector2(transform.position.x , transform.position.y - speed * Time.deltaTime);

        if (transform.position.y < -6f) {
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D col) { 

        if (col.tag== "Fire")
        {

            Player.Score++;

            Instantiate(Explosion, transform.position, transform.rotation);

            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    
    }

}
