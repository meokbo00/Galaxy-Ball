using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartButtonManager : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject p1orp2;
    public GameObject singleSetting;
    public Button Play;
=======
    public GameObject SinglePlaySetting;
    public Button SinglePlayer;
    public Button MultiPlayer;
>>>>>>> 764a6f52d4518392b1cf538f43e2832210de603b
    public Button Setting;
    public Button Quit;

    public Button singleP;
    public Button multiP;
    public Button x;


    public AudioSource ButtonAudio;

<<<<<<< HEAD
    void Start()
    {
        this.Play.onClick.AddListener(() =>
        {
            ButtonAudio.Play();
            p1orp2.gameObject.SetActive(true);
        });

        this.Setting.onClick.AddListener(() =>
        {
            ButtonAudio.Play();
            SceneManager.LoadScene("Setting Scene");
        });
=======
    private TextMeshProUGUI singlePlayerText;
    private TextMeshProUGUI onlinePlayText;

    void Start()
    {
        singlePlayerText = SinglePlayer.GetComponentInChildren<TextMeshProUGUI>();

        SinglePlayer.onClick.AddListener(OnSinglePlayerClicked);
        MultiPlayer.onClick.AddListener(OnMultiPlayerClicked);
        Setting.onClick.AddListener(OnSettingClicked);
        Quit.onClick.AddListener(OnQuitClicked);
    }
>>>>>>> 764a6f52d4518392b1cf538f43e2832210de603b

        this.Quit.onClick.AddListener(() =>
        {
            Debug.Log("게임 종료!");
            ButtonAudio.Play();
            Application.Quit();
        });

<<<<<<< HEAD
        this.singleP.onClick.AddListener(() =>
        {
            ButtonAudio.Play();
            singleSetting.gameObject.SetActive(true);
        });

        this.multiP.onClick.AddListener(() =>
        {
            ButtonAudio.Play();
            SceneManager.LoadScene("Main Scene");
        });

        this.x.onClick.AddListener(() =>
        {
            ButtonAudio.Play();
            this.p1orp2.gameObject.SetActive(false);
        });
=======

    void OnSettingClicked()
    {
        ButtonAudio.Play();
        SceneManager.LoadScene("Setting Scene");
    }

    void OnQuitClicked()
    {
        ButtonAudio.Play();
        Application.Quit();
        Debug.Log("게임 종료!");
>>>>>>> 764a6f52d4518392b1cf538f43e2832210de603b
    }
}