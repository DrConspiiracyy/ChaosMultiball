using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public float dampTime = 0.15f;
    private Vector3 _velocity = Vector3.zero;
    public Transform target;

    private Camera _camera;
    private float _fixedHeight;

    void Start()
    {
 
        _camera = GetComponent<Camera>();


        _fixedHeight = transform.position.x;
    }

    void Update()
    {
        if (target)
        {

            float depth = Vector3.Dot(
                           target.position - transform.position,
                           transform.forward
            );


            Vector3 viewportFocus = new Vector3(0.5f, 0.5f, depth);
            Vector3 worldFocus = _camera.ViewportToWorldPoint(viewportFocus);

            Vector3 delta = target.position - worldFocus;
            Vector3 destination = transform.position + delta;


            destination.x = _fixedHeight;

            transform.position = Vector3.SmoothDamp(
                                    transform.position,
                                    destination,
                                    ref _velocity,
                                    dampTime
            );
        }
    }
}