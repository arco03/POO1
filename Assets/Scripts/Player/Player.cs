using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float x;
    [Header("Movement")]
    [SerializeField] private string Horizontal;
    [SerializeField] private float speed;
    [Header("Jump")]
    [SerializeField] private float jumpForce;
    [SerializeField] private bool onGround;
    [SerializeField] private string JumpKey;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        //Movimiento del jugador
        x = Input.GetAxisRaw(Horizontal);
        Vector2 xMovement = new Vector2 (x, 0);
        rb.velocity = new Vector2 (xMovement.x*speed, rb.velocity.y);
    }
    private void Update()
    {
        if (onGround && Input.GetKeyDown(JumpKey))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            onGround = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
