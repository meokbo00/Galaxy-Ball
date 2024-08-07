using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless_Skill : MonoBehaviour
{
    BGMControl bGMControl;
    public float speed = GameManager.shotDistance; 
    private Rigidbody2D rb;
    private Vector2 lastVelocity;

    void Start()
    {
        bGMControl = FindObjectOfType<BGMControl>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.velocity = GameManager.shotDirection * speed;
    }

    void FixedUpdate()
    {
        lastVelocity = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        bGMControl.SoundEffectPlay(0);
        Vector2 normal = collision.contacts[0].normal;
        Vector2 reflectDirection = Vector2.Reflect(lastVelocity.normalized, normal);

        rb.velocity = reflectDirection * speed;
    }
}
