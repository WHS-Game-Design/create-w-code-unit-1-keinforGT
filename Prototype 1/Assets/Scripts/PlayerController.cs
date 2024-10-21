using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variable 
    private float speed = 20.0f;
    private float trunSpeed = 45.0f;
    private float horizontalinput;
    private float forwardinput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");

        //We Move the veicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        //We turn the veicle 
        transform.Rotate(Vector3.up, trunSpeed * horizontalinput * Time.deltaTime);
        
    }
}
