using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPoint : MonoBehaviour
{
    // Start is called before the first frame update
    static int points = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void OnCollisionEnter(Collision collision)
    {
        Vector3 scaleChange = new Vector3(0.0f, +1.0f, 0.0f);
         if (collision.gameObject.tag == "Player")
        {
             transform.localScale += scaleChange;
             points++;
        }
    }
}
