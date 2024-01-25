using UnityEngine;

public class HorizontalMovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform endPoint;
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
        if (transform.position.x > endPoint.position.x)
            currentSpeed = -speed;
        if (transform.position.x < startPoint.x)
            currentSpeed = speed;
        rb.velocity = new Vector2(currentSpeed, 0);
    }
}