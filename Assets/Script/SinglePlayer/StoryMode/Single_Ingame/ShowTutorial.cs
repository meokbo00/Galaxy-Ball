using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 요소를 사용하기 위해 추가
<<<<<<< HEAD
using UnityEngine.EventSystems; // 클릭 이벤트 처리를 위해 추가
=======
>>>>>>> 8b516b18d7ad2d8bf73e9005de6c72dcb5492d1a

public class ShowTutorial : MonoBehaviour
{
    public GameObject[] FirstTutorial;
    public GameObject[] SecondTutorial;
<<<<<<< HEAD
    private int currentIndex = 0; // 현재 활성화된 튜토리얼 이미지의 인덱스
    private List<GameObject> instantiatedImages = new List<GameObject>(); // 생성된 튜토리얼 이미지들을 저장할 리스트
    private StageGameManager stageGameManager;

    void Start()
    {
        stageGameManager = FindObjectOfType<StageGameManager>();

        if (stageGameManager.StageClearID == 1)
        {
            ShowTutorialImages(FirstTutorial);
        }
        else if (stageGameManager.StageClearID == 7)
        {
            ShowTutorialImages(SecondTutorial);
        }
    }

    void ShowTutorialImages(GameObject[] tutorialArray)
    {
        stageGameManager.PauseGame(); // 게임 일시정지

        foreach (GameObject tutorial in tutorialArray)
        {
            GameObject instantiatedImage = Instantiate(tutorial, new Vector3(540, 960, 0), Quaternion.identity, transform);
            instantiatedImage.SetActive(false); // 일단 비활성화
            instantiatedImages.Add(instantiatedImage);
        }

        if (instantiatedImages.Count > 0)
        {
            instantiatedImages[0].SetActive(true); // 첫 번째 튜토리얼 이미지를 활성화
        }

        // 클릭 이벤트 등록
        foreach (GameObject tutorial in instantiatedImages)
        {
            EventTrigger trigger = tutorial.AddComponent<EventTrigger>();

            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerClick;
            entry.callback.AddListener((eventData) => { OnImageClick(); });

            trigger.triggers.Add(entry);
        }
    }

    void OnImageClick()
    {
        if (currentIndex < instantiatedImages.Count - 1)
        {
            instantiatedImages[currentIndex].SetActive(false); // 현재 이미지를 비활성화
            currentIndex++;
            instantiatedImages[currentIndex].SetActive(true); // 다음 이미지를 활성화
        }
        else
        {
            // 마지막 이미지인 경우 모든 튜토리얼 이미지를 비활성화하고 게임 재개
            foreach (GameObject tutorial in instantiatedImages)
            {
                tutorial.SetActive(false);
            }
            stageGameManager.ResumeGame(); // 게임 재개
=======
    public Button nextButton; // UI 버튼을 참조
    private GameObject[] currentTutorial;
    private int currentIndex;

    void Start()
    {
        StageGameManager stageGameManager = FindObjectOfType<StageGameManager>();

        if (stageGameManager != null)
        {
            if (stageGameManager.StageClearID == 1)
            {
                currentTutorial = FirstTutorial;
            }
            else if (stageGameManager.StageClearID == 7)
            {
                currentTutorial = SecondTutorial;
            }

            if (currentTutorial != null && currentTutorial.Length > 0)
            {
                ActivateTutorialElement(0); // 첫 번째 요소를 활성화
                currentIndex = 0;
                nextButton.onClick.AddListener(OnNextButtonClicked); // 버튼 클릭 이벤트 추가
            }
        }
    }

    void ActivateTutorialElement(int index)
    {
        for (int i = 0; i < currentTutorial.Length; i++)
        {
            currentTutorial[i].SetActive(i == index); // 해당 인덱스만 활성화
        }
    }

    void OnNextButtonClicked()
    {
        currentIndex++;

        if (currentIndex >= currentTutorial.Length)
        {
            // 모든 요소 비활성화
            foreach (GameObject obj in currentTutorial)
            {
                obj.SetActive(false);
            }
            nextButton.onClick.RemoveListener(OnNextButtonClicked); // 버튼 클릭 이벤트 제거
        }
        else
        {
            ActivateTutorialElement(currentIndex);
>>>>>>> 8b516b18d7ad2d8bf73e9005de6c72dcb5492d1a
        }
    }
}
