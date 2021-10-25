using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avoid : MonoBehaviour
{

        public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float dir = Vector3.Distance(Player.transform.position, transform.position);
         if(dir < 10.0f){
             transform.position += -(Player.transform.position - transform.position).normalized * Time.deltaTime * 2.0f;
         }
        
    }
}
