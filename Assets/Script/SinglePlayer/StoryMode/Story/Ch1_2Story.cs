using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using UnityEngine.SceneManagement; // ï¿½ï¿½ ï¿½ï¿½È¯ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ß°ï¿½
=======
using UnityEngine.SceneManagement; // ¾À ÀüÈ¯À» À§ÇØ Ãß°¡
>>>>>>> 8237a960678fcc60926e65bab54cb94d2e566c32

public class Ch1_2Story : MonoBehaviour
{
    StageGameManager stageGameManager;
    StageBallController stageBallController;
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
        stageBallController = FindObjectOfType<StageBallController>();

        Color color = fadeImage.color;
        color.a = 1f;
        fadeImage.color = color;

        if (stageGameManager.StageClearID == 6)
        {
            stageBallController.enabled = false;
            Fadeinout.SetActive(true);
            textManager.GiveMeTextId(4);
            Clock.SetActive(true);
            remainTime = FindObjectOfType<RemainTime>();
            remainTime.years = 0;
            remainTime.days = 0;
            remainTime.hours = 0;
            remainTime.minutes = 0;
            remainTime.seconds = 0;

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
            if (showText.logTextIndex > 38)
            {
                stageBallController.enabled = true;
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
<<<<<<< HEAD
            color.a += Time.deltaTime / 5; // 2ï¿½Ê¿ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½Ìµï¿½ ï¿½ï¿½
=======
            color.a += Time.deltaTime / 5; // 2ÃÊ¿¡ °ÉÃÄ ÆäÀÌµå ÀÎ
>>>>>>> 8237a960678fcc60926e65bab54cb94d2e566c32
            fadeImage.color = color;
            yield return null;
        }

<<<<<<< HEAD
        // ï¿½ï¿½ï¿½Ä°ï¿½ï¿½ï¿½ 1ï¿½ï¿½ ï¿½Ç¸ï¿½ 3ï¿½ï¿½ ï¿½ï¿½ï¿½
        yield return new WaitForSeconds(3f);

        // "Main Stage"ï¿½ï¿½ ï¿½ï¿½ ï¿½ï¿½È¯
=======
        // ¾ËÆÄ°ªÀÌ 1ÀÌ µÇ¸é 3ÃÊ ´ë±â
        yield return new WaitForSeconds(3f);

        // "Main Stage"·Î ¾À ÀüÈ¯
>>>>>>> 8237a960678fcc60926e65bab54cb94d2e566c32
        SceneManager.LoadScene("Main Stage");
    }
}
