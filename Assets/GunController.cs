using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Bullet;
    public float BulletSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) 
        { 
            var bullet = Instantiate(Bullet,SpawnPoint.position,SpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward*BulletSpeed*Time.deltaTime;
        }
    }
}
