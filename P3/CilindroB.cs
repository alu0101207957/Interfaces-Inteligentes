using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroB : MonoBehaviour
{

    private Rigidbody rb;
    private Renderer render;

    // Start is called before the first frame update
    void Start()
    {
        GameController.EventoAcercamientoA += whenCloseA;
        GameController.EventoColisionA += whenColisionA;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void whenCloseA (){
        // Cambio de color
        render = GetComponent<Renderer>();
        Color col = new Color(Random.value, Random.value, Random.value);
        render.material.color = col;
    }

    void whenColisionA(){
         // Cambio de masa Fuerza de gravedad superior
        rb.mass *= 2;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){
            GameController.colisionB();
        }
    }

}
