using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject [] bulletPrefab;
    public float shootTime = 4.8f;
    bool flag = true;
    float temporary, finalTime;

    
    void Start()
    {
       
    }

    void Update()
    {
   
        if(flag)
        {
            temporary = shootTime;
            flag = false;     
            finalTime = temporary;
            Shoot();
        }
        
        shootTime -= Time.deltaTime;

        if (shootTime <= 0)
        {
            flag = true;
            shootTime = finalTime;
        }
    }

    private void Shoot()
    {
        int randomNumber = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[randomNumber], transform);
    }
}
