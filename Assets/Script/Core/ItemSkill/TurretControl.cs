using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    Rigidbody2D rigid;
    Vector2 lastVelocity;
    float deceleration = 2f;
    private bool iscolliding = false;
    private bool isStopped = false;
    private bool hasBeenReleased = false;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 최초 클릭 이후에만 힘이 가해지도록 설정
        if (Input.GetMouseButtonUp(0) && rigid != null && !hasBeenReleased)
        {
            rigid.velocity = GameManager.shotDirection * GameManager.shotDistance; // GameManager에서 값 가져와서 구체 발사
            hasBeenReleased = true; // 최초 클릭이 되었음을 표시
        }
        Move();
    }

    void Move()
    {
        if (rigid == null || isStopped) return;

        lastVelocity = rigid.velocity;
        rigid.velocity -= rigid.velocity.normalized * deceleration * Time.deltaTime;

        if (rigid.velocity.magnitude <= 0.01f)
        {
            isStopped = true;
            StartCoroutine(DestroyRigidbodyDelayed());
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.contacts != null && coll.contacts.Length > 0)
        {
            Vector2 dir = Vector2.Reflect(lastVelocity.normalized, coll.contacts[0].normal);
            if (rigid != null)
                rigid.velocity = dir * Mathf.Max(lastVelocity.magnitude, 0f); // 감속하지 않고 반사만 진행
        }
        this.iscolliding = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        this.iscolliding = false;
    }

    IEnumerator DestroyRigidbodyDelayed()
    {
        yield return new WaitForSeconds(0.8f);
        if (rigid != null)
            Destroy(rigid);
    }
}
