using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumppower;
    bool isGrounded = true;

    private void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {
        if (Input.GetButtonDown("Jump") && isGrounded){
            rb.AddForce(new Vector2(0,jumppower), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }
}