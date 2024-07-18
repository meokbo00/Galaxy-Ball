using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement; // �� ��ȯ�� ���� �߰�
=======
using UnityEngine.SceneManagement; // �� ��ȯ�� ���� �߰�
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c

public class Ch3Story : MonoBehaviour
{
    public Camera Camera;
    public GameObject Fadein;
<<<<<<< HEAD
    public AudioSource[] AudioSources; // ����� �ҽ� �迭
=======
    public AudioSource[] AudioSources; // ����� �ҽ� �迭
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c
    StageGameManager stageGameManager;
    TextManager textManager;
    ShowText showText;
    private bool isZooming = false;

<<<<<<< HEAD
    private bool isAudio1Played = false; // ù ��° ����� ��� ����
    private bool isAudio2Played = false; // �� ��° ����� ��� ����
=======
    private bool isAudio1Played = false; // ù ��° ����� ��� ����
    private bool isAudio2Played = false; // �� ��° ����� ��� ����
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c

    void Start()
    {
        showText = FindObjectOfType<ShowText>();
        textManager = FindObjectOfType<TextManager>();
        stageGameManager = FindObjectOfType<StageGameManager>();

        if (stageGameManager.StageClearID == 65)
        {
            textManager.GiveMeTextId(1);
        }
    }

    void Update()
    {
        showText = FindObjectOfType<ShowText>();
        if (showText != null && stageGameManager.StageClearID == 65)
        {
            if (showText.logTextIndex == 8 && !isZooming)
            {
                StartCoroutine(SmoothZoom(5f, 1700f));
            }
            if (showText.logTextIndex == 12)
            {
                StartCoroutine(ExecuteAfterDelay(4f));
            }
            if (showText.logTextIndex == 25)
            {
<<<<<<< HEAD
                StartCoroutine(LoadSceneAfterDelay(4f, "Story-InGame"));
=======
                StartCoroutine(LoadSceneAfterDelay(5f, "Story-InGame"));
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c
            }
        }
    }

    IEnumerator SmoothZoom(float duration, float targetSize)
    {
        isZooming = true;
        float startSize = Camera.orthographicSize;
        float elapsed = 0f;

<<<<<<< HEAD
        // ����� �ҽ� �迭�� ù ��° ������� ������� ���� ��� ���
        if (AudioSources.Length > 0 && !isAudio1Played)
        {
            AudioSources[0].Play();
            isAudio1Played = true; // ù ��° ����� ��� ���� ����
=======
        // ����� �ҽ� �迭�� ù ��° ������� ������� ���� ��� ���
        if (AudioSources.Length > 0 && !isAudio1Played)
        {
            AudioSources[0].Play();
            isAudio1Played = true; // ù ��° ����� ��� ���� ����
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c
        }

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            Camera.orthographicSize = Mathf.Lerp(startSize, targetSize, elapsed / duration);
            yield return null;
        }

        Camera.orthographicSize = targetSize;
        isZooming = false;
    }

    IEnumerator ExecuteAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Fadein.SetActive(true);

<<<<<<< HEAD
        // ����� �ҽ� �迭�� �� ��° ������� ������� ���� ��� ���
        if (AudioSources.Length > 1 && !isAudio2Played)
        {
            AudioSources[1].Play();
            isAudio2Played = true; // �� ��° ����� ��� ���� ����
=======
        // ����� �ҽ� �迭�� �� ��° ������� ������� ���� ��� ���
        if (AudioSources.Length > 1 && !isAudio2Played)
        {
            AudioSources[1].Play();
            isAudio2Played = true; // �� ��° ����� ��� ���� ����
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c
        }
    }

    IEnumerator LoadSceneAfterDelay(float delay, string sceneName)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
