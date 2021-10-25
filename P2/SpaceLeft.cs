using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            Vector3 dir = -(Player.transform.position - transform.position).normalized;
            dir.y = 0;
            transform.position += dir * Time.deltaTime;
        }
         if(Input.GetKey(KeyCode.LeftControl)){
            Vector3 dir = (Player.transform.position - transform.position).normalized;
            dir.y = 0;
            transform.position += dir * Time.deltaTime;
        }
    }
}
