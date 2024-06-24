using UnityEngine;

public class ContinuousRandomMovement : MonoBehaviour
{
<<<<<<< HEAD
=======
    public float moveSpeed = Random.Range(1,10); // 이동 속도
>>>>>>> b70e7ded257c502d9ffe6f9e137259f9f19790c9

    private Vector2 moveDirection; // 이동 방향

    void Start()
    {
<<<<<<< HEAD
        gameObject.transform.position = new Vector2(Random.Range(-400, 225), Random.Range(-300, 300));
=======
>>>>>>> b70e7ded257c502d9ffe6f9e137259f9f19790c9
        float randomAngle = Random.Range(0f, 360f);
        moveDirection = new Vector2(Mathf.Cos(randomAngle * Mathf.Deg2Rad), Mathf.Sin(randomAngle * Mathf.Deg2Rad));

        moveDirection.Normalize();
    }

    void Update()
    {
<<<<<<< HEAD
        transform.Translate(moveDirection * Random.Range(2, 17) * Time.deltaTime);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        StageGameManager gameManager = FindObjectOfType<StageGameManager>();

        switch (collision.gameObject.name)
        {
            case "Bottom":
                if (gameManager.StageClearID < 6)
                {
                    transform.Translate(0, 470, 0);
                }
                transform.Translate(0, 170, 0);
                break;
            case "Top":
                if (gameManager.StageClearID < 6)
                {
                    transform.Translate(0, -470, 0);
                }
                transform.Translate(0, -170, 0);
                break;
            case "Left":
                if (gameManager.StageClearID < 6)
                {
                    transform.Translate(460, 0, 0);
                }
                transform.Translate(165, 0, 0);
                break;
            case "Right":
                if (gameManager.StageClearID < 6)
                {
                    transform.Translate(-460, 0, 0);
                }
                transform.Translate(-165, 0, 0);
                break;
        }
=======
        transform.Translate(moveDirection * Random.Range(1, 10) * Time.deltaTime);
>>>>>>> b70e7ded257c502d9ffe6f9e137259f9f19790c9
    }
}