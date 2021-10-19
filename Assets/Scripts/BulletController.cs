using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float speed = 6.5f;
    Vector3 direction = Vector3.right;
    public float DestroyTime = 5.8f;
    
    void Start()
    {
       
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        DestroyTime -= Time.deltaTime;

        if (DestroyTime <= 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoubleScale();
        }
    }

    private void DoubleScale()
    {
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y * 2, transform.localScale.z * 2);
    }
    
}
