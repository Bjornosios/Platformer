using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [Header("Player stats")]
    [SerializeField] float MoveSpeed;
    [SerializeField] float JumpForce;
    Vector2 MoveVector;
    Rigidbody2D PlayerRb;
    private void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Jump");

        }
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        MoveVector = context.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        
    }
}
