using UnityEngine;
using UnityEngine.InputSystem;

public class POU_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            myRigidbody.linearVelocity = Vector2.up * jumpForce;
        }
    }
}
