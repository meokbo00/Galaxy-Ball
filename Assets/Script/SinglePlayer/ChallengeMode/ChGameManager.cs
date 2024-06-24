using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChallengeGameManager : MonoBehaviour
{
    public GameObject P1ballPrefab;
    public GameObject[] FireItemPrefab;
    public GameObject P1firezone;
    public GameObject P1Itemsave;
    public GameObject fireitem;

    private Vector3 clickPosition;
    private StageGameManager gameManager;
    public bool isDragging = false;
    public static float shotDistance;
    public static Vector3 shotDirection;

    public int maxscorenum;
    public int scorenum;
    public TMP_Text maxscoretext;
    public TMP_Text scoretext;

    private void Start()
    {
        P1firezone.gameObject.SetActive(true);
    }
    public void PrintDestroyedicontag(string icontag)
    {
        this.fireitem = null;
        switch (icontag)
        {
            case "Item_Big": fireitem = FireItemPrefab[0]; break;
            case "Item_Small": fireitem = FireItemPrefab[1]; break;
            case "Item_Twice": fireitem = FireItemPrefab[2]; break;
            case "Item_BlackHole": fireitem = FireItemPrefab[3]; break;
            case "Item_Invincible": fireitem = FireItemPrefab[4]; break;
        }
    }
    private void Update()
    {
        maxscoretext.text = maxscorenum.ToString();
        scoretext.text = scorenum.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 0f;
            Collider2D[] colliders = Physics2D.OverlapPointAll(clickPosition);
            foreach (Collider2D collider in colliders)
            {
                if (collider.gameObject == P1firezone)
                {
                    if (fireitem != null)
                    {
                        Instantiate(fireitem, clickPosition, Quaternion.identity);
                        Debug.Log("P1�� �������� ����Ͽ����ϴ�");
                        Debug.Log("�������� �̸��� " + fireitem.gameObject.name + "�Դϴ�");
                        isDragging = true;
                        fireitem = null;
                        break;
                    }
                    else
                    {
                        Instantiate(P1ballPrefab, clickPosition, Quaternion.identity);
                        Debug.Log("P1�� �⺻��ü�� ���Ƚ��ϴ�");
                        isDragging = true;
                        break;
                    }
                }
            }
        }

        if (isDragging && Input.GetMouseButtonUp(0))
        {
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;
            GameManager.shotDistance = Vector3.Distance(clickPosition, currentPosition);
            Vector3 dragDirection = (currentPosition - clickPosition).normalized;
            GameManager.shotDirection = -dragDirection;
            isDragging = false;
        }

        int totalBalls = GameObject.FindGameObjectsWithTag("EnemyBall").Length +
                       GameObject.FindGameObjectsWithTag("P1ball").Length;
        if (totalBalls > 15)
        {
            SceneManager.LoadScene("ChallengeFail");
        }
    }

}