using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position +=  moveDirection * speed * Time.deltaTime;

        if (Input.GetAxis("Mouse ScrollWheel") < 0) {
            transform.Rotate(Vector3.up * speed, Space.Self);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0) {
            transform.Rotate(Vector3.down * speed, Space.Self);
        }
        
    }
}
