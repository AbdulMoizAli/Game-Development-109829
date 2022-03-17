using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ball;
    float initialSpeed = 100.0f;
    float ballSpeedIncrement = 1.15f;
    float paddleSpeedIncrement = 1.0f;

    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        ball.AddForce(new Vector2(1.0f, -1.0f) * initialSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Paddle"))
        {
            ball.velocity = ball.velocity * ballSpeedIncrement;
            increasePaddleSpeed();
        }
    }

    // Implemented by Muhammad Yousuf
    void increasePaddleSpeed()
    {
        foreach (var obj in GameObject.FindGameObjectsWithTag("Paddle"))
        {
            var paddle = obj.GetComponent<Paddle>();
            paddle.Speed += paddleSpeedIncrement;
        }
    }
}
