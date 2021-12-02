using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 3;
    private Rigidbody2D rb;

    [SerializeField]
    [Range(0.0f, 30.0f)]
    private float jetpackStrength = 1.0f;

    [SerializeField]
    [Range(0.0f, 30.0f)]
    private float movementStrength = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector2.up * jetpackStrength);
        }

        float horizontalAxis = Input.GetAxis("Horizontal");

        rb.AddTorque(-horizontalAxis);

        //rb.AddForce(Vector2.right * movementStrength * horizontalAxis);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Health")
        {
            Destroy(collision.gameObject);
            health++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Planet")
        {
            health--;
        }
    }
}
