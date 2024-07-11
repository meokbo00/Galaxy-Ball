using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2Story : MonoBehaviour
{
    public Camera Camera;
    public GameObject Fadein;
    StageGameManager stageGameManager;
    StageBallController stageBallController;
    TextManager textManager;
    ShowText showText;

    void Start()
    {
        showText = FindObjectOfType<ShowText>();
        textManager = FindObjectOfType<TextManager>();
        stageGameManager = FindObjectOfType<StageGameManager>();
        stageBallController = FindObjectOfType<StageBallController>();

<<<<<<< HEAD

        switch (stageGameManager.StageClearID)
        {
            case 6:
                textManager.GiveMeTextId(1);
                Fadein.SetActive(true);
                Camera.orthographicSize = 150;

                if (stageBallController != null)
                {
                    stageBallController.enabled = false;
                }
                break;
            case 7:
                textManager.GiveMeTextId(2);
                break;
            case 16:
                textManager.GiveMeTextId(3);
                break;
            case 19:
                textManager.GiveMeTextId(4);
                break;
            case 25:
                textManager.GiveMeTextId(5);
                break;
            case 29:
                textManager.GiveMeTextId(6);
                break;
            case 33:
                textManager.GiveMeTextId(7);
                break;
=======
        if (stageGameManager.StageClearID == 6)
        {
            textManager.GiveMeTextId(1);
            Fadein.SetActive(true);
            Camera.orthographicSize = 150; 

            if (stageBallController != null)
            {
                stageBallController.enabled = false;
            }
        }
        if(stageGameManager.StageClearID == 7)
        {
            textManager.GiveMeTextId(2);
        }

        if(stageGameManager.StageClearID == 16)
        {
            textManager.GiveMeTextId(3);
>>>>>>> 8237a960678fcc60926e65bab54cb94d2e566c32
        }
    }

    void Update()
    {
        showText = FindObjectOfType<ShowText>();
        if (showText != null && stageGameManager.StageClearID == 6)
        {
            if (showText.logTextIndex == 3)
            {
                Fadein.SetActive(false);
            }
            if (showText.logTextIndex == 4)
            {
<<<<<<< HEAD
                StartCoroutine(ChangeCameraSize(150, 4, 5f)); // 2ï¿½Ê¿ï¿½ ï¿½ï¿½ï¿½ï¿½ Ä«ï¿½Þ¶ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½
=======
                StartCoroutine(ChangeCameraSize(150, 4, 5f)); // 2ÃÊ¿¡ °ÉÃÄ Ä«¸Þ¶ó »çÀÌÁî º¯°æ
>>>>>>> 8237a960678fcc60926e65bab54cb94d2e566c32
            }
            if (showText.logTextIndex == 36)
            {
                stageBallController.enabled = true;
            }
        }
    }

    IEnumerator ChangeCameraSize(float fromSize, float toSize, float duration)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            Camera.orthographicSize = Mathf.Lerp(fromSize, toSize, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        Camera.orthographicSize = toSize;
    }
}
