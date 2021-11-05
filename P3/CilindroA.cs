using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CilindroA : MonoBehaviour
{
    private GameObject jugador;
    public Text mensaje;



    // Start is called before the first frame update
    void Start()
    {
        GameController.EventoColisionB += whenColisionB;
    }

    // Update is called once per frame
    void Update()
    {
        jugador = GameObject.FindWithTag("Player");
        if(jugador == null) {
            return;
        }
        float distanciaJugador = Vector3.Distance(jugador.transform.position, transform.localPosition);
        if (distanciaJugador < 5.0f) {
            GameController.closeToA();
        }
    }

    void whenColisionB (){
        mensaje.text = "Colision con B";
    }

      void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){
            GameController.colisionA();
        }
    }
}
