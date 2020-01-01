using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody2D rb2d;
    public Transform groundCheck;
    private bool onGround = true;
    private float jumpforce = 300f;
    public static bool qst = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        onGround = Physics2D.Linecast(transform.position, groundCheck.position,1 << LayerMask.NameToLayer("Ground"));
        float h = Input.GetAxis("Horizontal");
        if (!qst)
        {
            rb2d.velocity = new Vector2(h * speed, rb2d.velocity.y);
        }
        GetComponent<SpriteRenderer>().color = new Color32(185, 201, 65, 255);

        if (Input.GetButtonDown("Jump") && onGround && !qst)
        {
            Jump();
        }
    }

   

    void Jump() {

        rb2d.AddForce(Vector2.up * jumpforce);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
            qst = true;
                } 
}
