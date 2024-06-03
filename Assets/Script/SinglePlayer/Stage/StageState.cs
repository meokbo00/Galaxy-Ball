using UnityEngine;

public class StageState : MonoBehaviour
{
    public GameObject StageStart;
<<<<<<< HEAD
    public GameObject StartButton;
    public int stagenum;
    public static int chooseStage;
    private bool isclear;
=======
    public int stagenum;
    public static int chooseStage;
>>>>>>> 97f809a08c0b4705a5fd993a2ace9b72b79e8df8
    private StageGameManager gameManager;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        this.stagenum = int.Parse(gameObject.name[5].ToString());
        gameManager = StageGameManager.instance;
        int stageClearID = gameManager.StageClearID;

        spriteRenderer = GetComponent<SpriteRenderer>();

        if (stageClearID < this.stagenum)
        {
<<<<<<< HEAD
            isclear = false;
=======
            Debug.Log("big");
>>>>>>> 97f809a08c0b4705a5fd993a2ace9b72b79e8df8
            spriteRenderer.color = new Color32(73, 73, 73, 255);
        }
        else if (stageClearID == this.stagenum)
        {
<<<<<<< HEAD
            isclear = true;
=======
            Debug.Log("same");
>>>>>>> 97f809a08c0b4705a5fd993a2ace9b72b79e8df8
            spriteRenderer.color = new Color32(255, 61, 61, 255);
        }
        else
        {
<<<<<<< HEAD
            isclear = true;
=======
            Debug.Log("small");
>>>>>>> 97f809a08c0b4705a5fd993a2ace9b72b79e8df8
            spriteRenderer.color = new Color32(69, 155, 255, 255);
        }
    }

<<<<<<< HEAD
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "StageBall")
        {
            StageStart.gameObject.SetActive(true);
            if(!isclear)
            {
                StartButton.gameObject.SetActive(false);
            }
            else if(isclear)
            {
                StartButton.gameObject.SetActive(true) ;
            }
        }
        chooseStage = stagenum;
        Debug.Log(chooseStage);
        FindObjectOfType<ShowStageBox>().UpdateStageInfo(chooseStage);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "StageBall")
            StageStart.gameObject.SetActive(false);
    }
=======
    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "StageBall")
    //    {
    //        StageStart.gameObject.SetActive(true);
    //    }
    //    chooseStage = stagenum;
    //    Debug.Log($"chooseStage 값이 {chooseStage}로 설정되었습니다.");
    //    FindObjectOfType<ShowStageBox>().UpdateStageInfo(chooseStage);
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "StageBall")
    //        StageStart.gameObject.SetActive(false);
    //}
>>>>>>> 97f809a08c0b4705a5fd993a2ace9b72b79e8df8
}
