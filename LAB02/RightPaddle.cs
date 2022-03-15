using UnityEngine;

public class RightPaddle : Paddle
{
    void Start()
    {
        UpKey = KeyCode.UpArrow;
        DownKey = KeyCode.DownArrow;
        PaddleControl = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdatePaddlePosition();
    }
}
