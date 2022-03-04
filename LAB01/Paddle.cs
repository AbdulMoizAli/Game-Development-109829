using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected KeyCode UpKey { get; set; }
    protected KeyCode DownKey { get; set; }
    public float Speed { get; set; } = 5.0f;
    protected Rigidbody2D PaddleControl { get; set; }

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
