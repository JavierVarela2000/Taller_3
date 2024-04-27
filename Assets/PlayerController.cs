using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular el movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical) * velocidad * Time.deltaTime;

        // Aplicar el movimiento al objeto
        transform.Translate(movimiento);


        if(Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }


    private void Restart()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // Iterar sobre cada objeto y cambiar su color
        foreach (GameObject enemy in enemies)
        {
            // Verificar si el objeto tiene un componente Renderer
            Renderer renderer = enemy.GetComponent<Renderer>();
            if (renderer != null)
            {
                // Cambiar el color del cubo al color compartido
                renderer.material.color = Color.white;
            }
        }
    }
}
