using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 3;

    private void Awake()
    {
        Destroy(gameObject,lifeTime);
    }

    private void OnCollisionEnter()
    {
        
        Destroy(gameObject);
   
    }
}
