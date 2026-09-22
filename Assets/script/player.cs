using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    private bool isGrounded = false;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  

    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // vai fazer reconhecer o movimento horizontal

        rb.linearVelocity = new Vector2 (moveHorizontal * speed, rb.linearVelocity.y);

       if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); // vai servir para pular
        }
    }

    void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // vai reconhecer quando o jogador estiver no chão
        } 
    }
   void OnCollisionExit2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; // vai reconhecer quando o jogador pular e ficar no ar
        }
    }
}
