using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GameController : MonoBehaviour
{

    public delegate void Colision();
    public delegate void Acercamiento();
    public static event Acercamiento EventoAcercamientoA;
    public static event Colision EventoColisionA;
    public static event Colision EventoColisionB;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public static void closeToA()
    {
        EventoAcercamientoA();
    }


     public static void colisionA()
    {
        EventoColisionA();
    }
    public static void colisionB()
    {
        EventoColisionB();
    }

}
