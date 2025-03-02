using UnityEngine;

/// <summary>
/// Simplified spaceship controller with 360-degree rotation.
/// </summary>
public class SimpleController1 : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotationSpeed = 200.0f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float rotationInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(0, Input.GetAxis("Vertical"));
        rotationInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb.linearVelocity = transform.up * movement.y * moveSpeed;
        rb.angularVelocity = -rotationInput * rotationSpeed;
    }
}
