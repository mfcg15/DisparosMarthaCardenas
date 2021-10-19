using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool flag = true;
    float speedPlayer = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        if (flag)
        {
            MovePlayer(Vector3.right);
        }
        else
        {
            MovePlayer(Vector3.left);
        }

        if (transform.position.z < -4f && !flag)
        {
            flag = true;
        }

        if (transform.position.z > 5f && flag)
        {
            flag = false;
        }
    }

    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(speedPlayer * Time.deltaTime * direction);
    }
}
