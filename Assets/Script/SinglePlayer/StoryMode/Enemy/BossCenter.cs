using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BossCenter : MonoBehaviour
{
    BGMControl bGMControl;
    Rigidbody2D rigid;
    public float increase = 4f;
    public bool hasExpanded = false;
    public int randomNumber;
<<<<<<< HEAD
    public int initialRandomNumber; // ï¿½Ê±ï¿½ randomNumber ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½
    public TextMeshPro textMesh;
    public BossFire[] bossfires; // ï¿½ï¿½ï¿½ï¿½ Enemy1Fire ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½è¿­
=======
    public int initialRandomNumber; // ÃÊ±â randomNumber °ªÀ» ÀúÀåÇÒ º¯¼ö
    public TextMeshPro textMesh;
    public BossFire[] bossfires; // ¿©·¯ Enemy1Fire ÂüÁ¶¸¦ À§ÇÑ ¹è¿­
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b
    public bool isShowHP;

    public int MaxHP;
    public int MinHP;
    public float MaxFireTime;
    public float MinFireTime;
    public float MaxAngle;
    public float MinAngle;
    public float fontsize;

    public GameObject[] Enemy;

    private void Start()
    {
        bGMControl = FindObjectOfType<BGMControl>();
        rigid = GetComponent<Rigidbody2D>();
        GameObject textObject = new GameObject("TextMeshPro");
        textObject.transform.parent = transform;
        textMesh = textObject.AddComponent<TextMeshPro>();
        randomNumber = Random.Range(MinHP, MaxHP);
<<<<<<< HEAD
        initialRandomNumber = randomNumber; // ï¿½Ê±ï¿½ randomNumber ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½
=======
        initialRandomNumber = randomNumber; // ÃÊ±â randomNumber °ªÀ» ÀúÀå
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b
        if (isShowHP)
        {
            textMesh.text = randomNumber.ToString();
        }
        textMesh.fontSize = fontsize;
        textMesh.alignment = TextAlignmentOptions.Center;
        textMesh.autoSizeTextContainer = true;
        textMesh.rectTransform.localPosition = Vector3.zero;
        textMesh.sortingOrder = 3;

<<<<<<< HEAD
        bossfires = GetComponentsInChildren<BossFire>(); // Enemy1Fire ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Æ® ï¿½è¿­ ï¿½ï¿½ï¿½ï¿½
=======
        bossfires = GetComponentsInChildren<BossFire>(); // Enemy1Fire ÄÄÆ÷³ÍÆ® ¹è¿­ ÂüÁ¶
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b

        StartCoroutine(RandomAttack());
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "P1ball" || coll.gameObject.tag == "P2ball" || coll.gameObject.tag == "P1Item" || coll.gameObject.tag == "P2Item"
            || (coll.gameObject.tag == "Item" && coll.gameObject.name != "SPEndlessF(Clone)"))
        {
            if (randomNumber > 0)
            {
                randomNumber--;
                if (isShowHP)
                {
                    textMesh.text = randomNumber.ToString();
                }
            }
            if (randomNumber <= 0)
            {
                bGMControl.SoundEffectPlay(4);
<<<<<<< HEAD
                Destroy(transform.parent.gameObject); // ï¿½Î¸ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Æ® ï¿½ï¿½ï¿½ï¿½
=======
                Destroy(transform.parent.gameObject); // ºÎ¸ð ¿ÀºêÁ§Æ® »èÁ¦
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b
            }
        }
        if (coll.gameObject.name == "SPTwiceF(Clone)")
        {
            randomNumber -= 1;
            if (randomNumber > 0)
            {
                textMesh.text = randomNumber.ToString();
            }
            if (randomNumber <= 0)
            {
                bGMControl.SoundEffectPlay(4);
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator Attack1()
    {
<<<<<<< HEAD
        yield return new WaitForSeconds(Random.Range(MinFireTime, MaxFireTime));

        float targetAngle = Random.Range(MinAngle, MaxAngle);
        float currentAngle = transform.eulerAngles.z;
        float rotationTime = 1f; // È¸ï¿½ï¿½ï¿½Ï´ï¿½ ï¿½ï¿½ ï¿½É¸ï¿½ï¿½ï¿½ ï¿½Ã°ï¿½
        float elapsedTime = 0f;

=======
        // 5ÃÊ µ¿¾È Á¤Áö
        yield return new WaitForSeconds(Random.Range(MinFireTime, MaxFireTime));

        // È¸ÀüÇÒ °¢µµ ¼³Á¤
        float targetAngle = Random.Range(MinAngle, MaxAngle);
        float currentAngle = transform.eulerAngles.z;
        float rotationTime = 1f; // È¸ÀüÇÏ´Â µ¥ °É¸®´Â ½Ã°£
        float elapsedTime = 0f;

        // È¸ÀüÇÏ±â
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b
        while (elapsedTime < rotationTime)
        {
            elapsedTime += Time.deltaTime;
            float angle = Mathf.LerpAngle(currentAngle, targetAngle, elapsedTime / rotationTime);
            transform.eulerAngles = new Vector3(0, 0, angle);
            yield return null;
        }

<<<<<<< HEAD
=======
        // È¸ÀüÀÌ ³¡³­ ÈÄ 1ÃÊ µÚ¿¡ ÃÑ¾Ë ¹ß»ç
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b
        yield return new WaitForSeconds(1f);

        if (bossfires != null)
        {
            foreach (var enemy1Fire in bossfires)
            {
                enemy1Fire.SpawnBullet();
            }
        }
    }

    private IEnumerator Attack2()
    {
<<<<<<< HEAD
        yield return new WaitForSeconds(7);

        if (Enemy.Length > 0)
        {
=======
        yield return new WaitForSeconds(Random.Range(MinFireTime, MaxFireTime));

        if (Enemy.Length > 0)
        {
            // ·£´ýÀ¸·Î µÎ °³ÀÇ Àû ¿ÀºêÁ§Æ® ¼±ÅÃ
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b
            GameObject enemy1 = Enemy[Random.Range(0, Enemy.Length)];
            GameObject enemy2 = Enemy[Random.Range(0, Enemy.Length)];
            GameObject enemy3 = Enemy[Random.Range(0, Enemy.Length)];
            GameObject enemy4 = Enemy[Random.Range(0, Enemy.Length)];


<<<<<<< HEAD
=======
            // º¸½ºÀÇ ¾ç¿·¿¡ »ý¼º
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b
            Instantiate(enemy1, transform.position + new Vector3(-1.5f, 0, 0), Quaternion.identity);
            Instantiate(enemy2, transform.position + new Vector3(1.5f, 0, 0), Quaternion.identity);
            Instantiate(enemy3, transform.position + new Vector3(0, 1.5f, 0), Quaternion.identity);
            Instantiate(enemy4, transform.position + new Vector3(0, -1.5f, 0), Quaternion.identity);

        }
    }

    

    private IEnumerator RandomAttack()
    {
        while (true)
        {
            int randomAttack = Random.Range(0, 2);
            switch (randomAttack)
            {
                case 0:
                    yield return StartCoroutine(Attack1());
                    break;
                case 1:
                    yield return StartCoroutine(Attack2());
                    break;
            }

<<<<<<< HEAD
            yield return new WaitForSeconds(4f);
=======
            yield return new WaitForSeconds(4f); // 5ÃÊ ´ë±â ÈÄ ´ÙÀ½ °ø°Ý ¼±ÅÃ
>>>>>>> 9200afb59ac02edfdc489da017c782d240d6303b
        }
    }
}
