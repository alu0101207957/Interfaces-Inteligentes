using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Counter : MonoBehaviour
{
    public  int counter = 0;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        id = ManagerID.id++;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Id: "+ id + "|tag: " + gameObject.tag + "|Contador: " + counter);
        counter++;
        
    }
}
