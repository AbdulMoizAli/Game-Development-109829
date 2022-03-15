using UnityEngine;

public class LeftPaddle : Paddle
{
    void Start()
    {
        UpKey = KeyCode.W;
        DownKey = KeyCode.S;
        PaddleControl = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdatePaddlePosition();
    }
}
