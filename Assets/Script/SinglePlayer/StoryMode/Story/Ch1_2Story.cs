using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using UnityEngine.SceneManagement; // �� ��ȯ�� ���� �߰�
=======
>>>>>>> 7b90238aea4e51e77d0015c6da859eb111a1afdb

public class Ch1_2Story : MonoBehaviour
{
    StageGameManager stageGameManager;
    private ShowText showText;
    public GameObject Clock;
    public GameObject Fadeinout;
    public GameObject creation;
    RemainTime remainTime;
    public Image fadeImage;

    void Start()
    {
        showText = FindObjectOfType<ShowText>();
        fadeImage = Fadeinout.GetComponent<Image>();
        stageGameManager = FindObjectOfType<StageGameManager>();
        TextManager textManager = FindObjectOfType<TextManager>();

        Color color = fadeImage.color;
        color.a = 1f;
        fadeImage.color = color;

        if (stageGameManager.StageClearID == 6)
        {
            Fadeinout.SetActive(true);
            textManager.GiveMeTextId(4);
            Clock.SetActive(true);
            remainTime = FindObjectOfType<RemainTime>();
            remainTime.years = 0;
            remainTime.days = 0;
            remainTime.hours = 0;
<<<<<<< HEAD
            remainTime.minutes = 0;
            remainTime.seconds = 0;
=======
            remainTime.minutes = 2;
            remainTime.seconds = 30;

>>>>>>> 7b90238aea4e51e77d0015c6da859eb111a1afdb

            SpriteRenderer[] spriteRenderers = creation.GetComponentsInChildren<SpriteRenderer>();
            foreach (SpriteRenderer sr in spriteRenderers)
            {
                sr.color = Color.black;
            }

            ContinuousRandomMovement[] randomMovements = creation.GetComponentsInChildren<ContinuousRandomMovement>();
            foreach (ContinuousRandomMovement rm in randomMovements)
            {
                rm.enabled = false;
            }
        }
    }

    void Update()
    {
        showText = FindObjectOfType<ShowText>();

        if (showText != null && stageGameManager.StageClearID == 6)
        {
<<<<<<< HEAD
            if (showText.logTextIndex > 38)
            {
                Fadeinout.SetActive(false);
            }
            if (showText.logTextIndex == 48)
            {
                StartCoroutine(FadeIn());
            }
        }
    }

    IEnumerator FadeIn()
    {
        Fadeinout.SetActive(true);
        Color color = fadeImage.color;
        color.a = 0f;
        fadeImage.color = color;

        while (color.a < 1f)
        {
            color.a += Time.deltaTime / 5; // 2�ʿ� ���� ���̵� ��
            fadeImage.color = color;
            yield return null;
        }

        // ���İ��� 1�� �Ǹ� 3�� ���
        yield return new WaitForSeconds(3f);

        // "Main Stage"�� �� ��ȯ
        SceneManager.LoadScene("Main Stage");
=======
            if (showText.logTextIndex == 2)
            {
                Fadeinout.SetActive(false);
            }
            if (showText.logTextIndex == 8)
            {

            }
        }
>>>>>>> 7b90238aea4e51e77d0015c6da859eb111a1afdb
    }
}
