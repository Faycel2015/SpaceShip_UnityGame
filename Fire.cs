using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed = 2.5f;
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position = new Vector2(transform.position.x , transform.position.y + speed * Time.deltaTime);

        if (transform.position.y > 6f) {
            Destroy(gameObject);
        }
    }
}
