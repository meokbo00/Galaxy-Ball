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
        // JSON íŒŒì¼ì—ì„œ ë°ì´í„° ë¡œë“œ
        string jsonString = JsonFile.text;
        stageInfos = JsonConvert.DeserializeObject<Information[]>(jsonString);

        // ì´ˆê¸° í…ìŠ¤íŠ¸ ì„¤ì •
        informationText.text = "";
        stageTitleText.text = "";
=======
    public TextAsset JsonFile; // JSON ÆÄÀÏÀ» ÀúÀåÇÒ º¯¼ö
    public TMP_Text informationText; // Á¤º¸¸¦ Ãâ·ÂÇÒ TextMesh

    private void Start()
    {
        // ÃÊ±âÈ­ÇÒ ¶§´Â ¾Æ¹« Á¤º¸µµ Ãâ·ÂÇÏÁö ¾Êµµ·Ï ÇÕ´Ï´Ù.
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

        // stageID¿¡ ÇØ´çÇÏ´Â String °¡Á®¿À±â
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
                Debug.Log(info.id + "ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½Ô´Ï´ï¿½");
=======
                }
                Debug.Log(info.id + "¹ø ¼³¸íÀÔ´Ï´Ù");
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