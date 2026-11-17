using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [Header("Player stats")]
    [SerializeField] float MoveSpeed;
    [SerializeField] float JumpForce;
    [SerializeField] bool IsGrounded;
    [SerializeField] LayerMask GroundLayer;
    [SerializeField] Transform CheckGround;
    [SerializeField] int JumpAmount;
    [SerializeField] int MaxJumps;
    Vector2 MoveVector;
    Rigidbody2D PlayerRb;
    private void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        MaxJumps = 3;
    }
    
    void CheckForGround()
    {
        IsGrounded = Physics2D.OverlapCircle(CheckGround.position, 0.2f, GroundLayer);
    }

    private void OnDrawGizmosSelected()
    {
        if (IsGrounded)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }

        Gizmos.DrawWireSphere(CheckGround.position, 0.2f);
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Jump();
        }
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        MoveVector = context.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        PlayerRb.linearVelocity = new Vector2(MoveVector.x * MoveSpeed, PlayerRb.linearVelocity.y);
    }
    void Jump()
    {
        if (IsGrounded)
        {
            PlayerRb.linearVelocityY = 0;
            PlayerRb.AddForce(Vector2.up  * JumpForce, ForceMode2D.Impulse);
            JumpAmount = MaxJumps;
        }
        else
        {
            if (JumpAmount > 0)
            {
                PlayerRb.linearVelocityY = 0;
                PlayerRb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
                JumpAmount -= 1;
            }
        }
    }

    private void Update()
    {
        CheckForGround();
    }
}
