using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaledByDistance : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    private Vector3 startingScale;

    void Start()
    {
        startingScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject esfera = GameObject.FindWithTag("Esfera");
        float distanceEsfera = Vector3.Distance(esfera.transform.position, transform.position);
        float distancePlayer = Vector3.Distance(Player.transform.position, transform.position);

        transform.localScale = startingScale / distanceEsfera;
        transform.localScale *= distancePlayer;

        
    }
}
