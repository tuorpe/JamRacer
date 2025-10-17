using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxRotationAngle = 45f;
    [SerializeField, Range(1f, 100f)] private float rotationRate = 50f;
    [SerializeField]private float speed = 10f;
    [SerializeField] private float acceleration = 1f;
    public bool isGameStarted = false;
    Vector3 moveDirection = Vector3.zero;
    Rigidbody rb;
    Vector2 direction;

    private float currentSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.rotation = Quaternion.Euler(0, 90, 0);
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameStarted)
            return;
        Vector3 rotationVector = rb.rotation.eulerAngles;
        rotationVector.y += direction.x * rotationRate * Time.deltaTime;
        rb.MoveRotation(Quaternion.Euler(rotationVector));
        if (currentSpeed < speed)
            currentSpeed += Time.deltaTime * acceleration;
        else if (currentSpeed > speed)
            currentSpeed = speed;
        Vector3 velocity = transform.right * currentSpeed;
        velocity.y = rb.linearVelocity.y;
        rb.linearVelocity = velocity;
    }

    public void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
        Debug.Log(value.Get<Vector2>().x);
        /*if(transform.rotation.eulerAngles.y > maxRotationAngle)
            transform.rotation = Quaternion.Euler(0, 0, maxRotationAngle);
        else if (transform.rotation.eulerAngles.y < -maxRotationAngle)
            transform.rotation = Quaternion.Euler(0, 0, -maxRotationAngle);*/
    }
}
