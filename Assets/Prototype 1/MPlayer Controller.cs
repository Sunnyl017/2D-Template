using UnityEngine;
using UnityEngine.InputSystem;

public class MPlayerController : MonoBehaviour
{
    public new Collider2D collider;
    public new Rigidbody2D rb;
    private float movementX;
    private float movementY;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collider = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
public void OnMove(InputValue value)
    {
        Vector2 movementValue = value.Get<Vector2>();

        movementX = movementValue.x;
        movementY = movementValue.y;
    }
    public void FixedUpdate()
    {
        Vector3 movement = new(movementX, movementY, 0);
        rb.AddForce(movement * speed, ForceMode2D.Impulse);
    }
}
