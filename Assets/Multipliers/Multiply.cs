using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
    public GameObject ball;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
         transform.position = collision.transform.position;
         GameObject.Instantiate(ball, transform.position);
        
        }
    }


    void Start()
    {

    }

    void Update()
    {

    }

    

   

}
