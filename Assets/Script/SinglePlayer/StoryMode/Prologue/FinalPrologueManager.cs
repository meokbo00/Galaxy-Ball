using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
using UnityEngine.SceneManagement; // Scene Management ���ӽ����̽� �߰�
>>>>>>> 17bcf4c21ff3c9ee138a41d6376ba025b92a58b7

public class FinalPrologueManager : MonoBehaviour
{
    public GameObject[] images;

    void Start()
    {
<<<<<<< HEAD
=======
        // ��� �̹����� CanvasGroup�� �����մϴ�.
>>>>>>> 17bcf4c21ff3c9ee138a41d6376ba025b92a58b7
        foreach (GameObject image in images)
        {
            CanvasGroup canvasGroup = image.GetComponent<CanvasGroup>();
            if (canvasGroup == null)
            {
                canvasGroup = image.AddComponent<CanvasGroup>();
            }
<<<<<<< HEAD
            canvasGroup.alpha = 0f;  
=======
            canvasGroup.alpha = 0f;  // ó���� ��� �����ϰ� �����մϴ�.
>>>>>>> 17bcf4c21ff3c9ee138a41d6376ba025b92a58b7
        }

        StartCoroutine(ShowImagesSequentially());
    }

    IEnumerator ShowImagesSequentially()
    {
        foreach (GameObject image in images)
        {
            yield return StartCoroutine(FadeIn(image));
<<<<<<< HEAD
            yield return new WaitForSeconds(4.5f);  // 7�� - 1�� (���̵� �ƿ� �ð�)
=======
            yield return new WaitForSeconds(4.5f);  // 7�� - 1�� (���̵� �ƿ� �ð�)
>>>>>>> 17bcf4c21ff3c9ee138a41d6376ba025b92a58b7
            yield return StartCoroutine(FadeOut(image));
        }

        yield return new WaitForSeconds(2f);
<<<<<<< HEAD
=======
        // ������ �̹��� ���̵� �ƿ��� ���� �� "Stage" ������ ��ȯ
>>>>>>> 17bcf4c21ff3c9ee138a41d6376ba025b92a58b7
        SceneManager.LoadScene("Stage");
    }

    IEnumerator FadeIn(GameObject image)
    {
        CanvasGroup canvasGroup = image.GetComponent<CanvasGroup>();
        float duration = 2f;
        float elapsed = 0f;

        image.SetActive(true);

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(elapsed / duration);
            yield return null;
        }
        canvasGroup.alpha = 1f;
    }

    IEnumerator FadeOut(GameObject image)
    {
        CanvasGroup canvasGroup = image.GetComponent<CanvasGroup>();
        float duration = 1f;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(1f - (elapsed / duration));
            yield return null;
        }
        canvasGroup.alpha = 0f;

        image.SetActive(false);
    }
}
