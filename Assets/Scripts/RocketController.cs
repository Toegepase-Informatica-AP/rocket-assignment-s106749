using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    private Vector2 inputVector = new Vector2(0, 0);
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(inputVector * 1, ForceMode.Impulse);
    }

    public void OnFly(InputAction.CallbackContext context)
    {
        inputVector = context.ReadValue<Vector2>();
    }
}
