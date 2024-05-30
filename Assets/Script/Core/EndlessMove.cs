using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMove : MonoBehaviour
{

    public float speed = 5f; // �̵� �ӵ�
    private Rigidbody2D rb;
    private Vector2 lastVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // �߷� ���� ����
        rb.velocity = Vector2.right * speed; // �ʱ� �ӵ��� ���������� ����
    }

    void FixedUpdate()
    {
        lastVelocity = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹 ���� ���
        Vector2 normal = collision.contacts[0].normal;
        Vector2 reflectDirection = Vector2.Reflect(lastVelocity.normalized, normal);

        // �ݻ� �������� ������ �ӵ��� �̵�
        rb.velocity = reflectDirection * speed;
    }
}
