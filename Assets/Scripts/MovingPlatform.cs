using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Transform endPoint;
    Vector2 startPoint;
    Rigidbody2D rb;
    float currentSpeed;

    void Start()
    {
        startPoint = transform.position;
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = speed;
    }

    void FixedUpdate()
    {
        if (transform.position.y > endPoint.position.y)
            currentSpeed = -speed;
        if (transform.position.y < startPoint.y)
            currentSpeed = speed;
        rb.velocity = new Vector2(0, currentSpeed);
    }
}