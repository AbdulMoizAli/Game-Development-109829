// Implemented by Muhammad Yousuf
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected KeyCode UpKey;
    protected KeyCode DownKey;
    public float Speed = 5.0f;
    protected Rigidbody2D PaddleControl;

    protected void UpdatePaddlePosition()
    {
        float position = 0.0f;

        if (Input.GetKey(UpKey))
            position = Speed;
        else if (Input.GetKey(DownKey))
            position = -Speed;

        PaddleControl.velocity = new Vector2(PaddleControl.velocity.x, position);
    }
}
