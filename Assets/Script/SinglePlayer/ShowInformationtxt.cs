using UnityEngine;
using Newtonsoft.Json;
using TMPro;

public class ShowInformationtxt : MonoBehaviour
{
<<<<<<< HEAD
    public TextAsset JsonFile;
    public TMP_Text informationText;
    public TextMeshProUGUI stageTitleText;

    private Information[] stageInfos;

    private void Start()
    {
        // JSON 파일에서 데이터 로드
        string jsonString = JsonFile.text;
        stageInfos = JsonConvert.DeserializeObject<Information[]>(jsonString);

        // 초기 텍스트 설정
        informationText.text = "";
        stageTitleText.text = "";
=======
    public TextAsset JsonFile; // JSON ������ ������ ����
    public TMP_Text informationText; // ������ ����� TextMesh

    private void Start()
    {
        // �ʱ�ȭ�� ���� �ƹ� ������ ������� �ʵ��� �մϴ�.
        informationText.text = "";
>>>>>>> 1060694ac294c2727fc3c77bad9421d92ceca4aa
    }

    private void Update()
    {
        UpdateStageInfo();
    }

    public void UpdateStageInfo()
    {
        StageGameManager gameManager = FindObjectOfType<StageGameManager>();

<<<<<<< HEAD
        int stageID = StageState.chooseStage;
        int stageClearID = gameManager.StageClearID;

        string stageString = "";
        string stageTitle = "";

=======
        string jsonString = JsonFile.text;
        Information[] stageInfos = JsonConvert.DeserializeObject<Information[]>(jsonString);

        int stageID = StageState.chooseStage;
        int stageClearID = gameManager.StageClearID;

        // stageID�� �ش��ϴ� String ��������
        string stageString = "";
>>>>>>> 1060694ac294c2727fc3c77bad9421d92ceca4aa
        foreach (Information info in stageInfos)
        {
            if (info.id == stageID)
            {
                if (stageClearID < stageID)
                {
                    stageString = "<size=20>???</size>";
<<<<<<< HEAD
                    stageTitle = "<size=12>???</size>";
=======
>>>>>>> 1060694ac294c2727fc3c77bad9421d92ceca4aa
                }
                else
                {
                    stageString = info.String;
<<<<<<< HEAD
                    stageTitle = info.StageTitle;
                }
                Debug.Log(info.id + "�� �����Դϴ�");
=======
                }
                Debug.Log(info.id + "�� �����Դϴ�");
>>>>>>> 1060694ac294c2727fc3c77bad9421d92ceca4aa
                break;
            }
        }

        informationText.text = stageString;
<<<<<<< HEAD
        stageTitleText.text = stageTitle;
=======
>>>>>>> 1060694ac294c2727fc3c77bad9421d92ceca4aa
    }
}

[System.Serializable]
public class Information
{
    public int id;
<<<<<<< HEAD
    public string StageTitle;
=======
>>>>>>> 1060694ac294c2727fc3c77bad9421d92ceca4aa
    public string String;
}