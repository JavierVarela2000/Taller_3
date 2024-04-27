using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            _renderer.material.color = Color.white;
        }
    }

    private void OnCollisionEnter()
    {
        _renderer.material.color = Color.red;
    }
}
