using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarObjetivo : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        GameController.EventoAcercamientoA += whenCloseToA;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void whenCloseToA(){
        transform.LookAt(target);
        Debug.DrawRay(transform.position, (target.position - transform.position), Color.green);
    }
    
}
