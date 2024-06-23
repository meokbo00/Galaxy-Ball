using UnityEngine;

public class ContinuousRandomMovement : MonoBehaviour
{
    public float moveSpeed = Random.Range(1,10); // 이동 속도

    private Vector2 moveDirection; // 이동 방향

    void Start()
    {
        float randomAngle = Random.Range(0f, 360f);
        moveDirection = new Vector2(Mathf.Cos(randomAngle * Mathf.Deg2Rad), Mathf.Sin(randomAngle * Mathf.Deg2Rad));

        moveDirection.Normalize();
    }

    void Update()
    {
        transform.Translate(moveDirection * Random.Range(1, 10) * Time.deltaTime);
    }
}