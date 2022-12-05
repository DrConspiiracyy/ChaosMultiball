using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
    public GameObject ball;

    void OnCollision(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            GameObject.Instantiate(ball);
            transform.position = transform.position;
        }
    }


    void Start()
    {

    }

    void Update()
    {

    }

    

   

}
