using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
    public GameObject ball;
    Vector3 HitPos;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            HitPos = collision.transform.position;
            transform.position = collision.transform.position;
            GameObject.Instantiate(ball, transform.position, transform.rotation);

            
        }
    }


    void Start()
    {

    }

    void Update()
    {

    }

    

   

}
