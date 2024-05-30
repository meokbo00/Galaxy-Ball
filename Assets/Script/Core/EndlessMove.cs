using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMove : MonoBehaviour
{

    public float speed = 5f; // 이동 속도
    private Rigidbody2D rb;
    private Vector2 lastVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // 중력 영향 제거
        rb.velocity = Vector2.right * speed; // 초기 속도를 오른쪽으로 설정
    }

    void FixedUpdate()
    {
        lastVelocity = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌 방향 계산
        Vector2 normal = collision.contacts[0].normal;
        Vector2 reflectDirection = Vector2.Reflect(lastVelocity.normalized, normal);

        // 반사 방향으로 동일한 속도로 이동
        rb.velocity = reflectDirection * speed;
    }
}
