using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayBGM : MonoBehaviour
{
<<<<<<< HEAD
    public AudioSource[] BGM; // 오디오 소스를 배열로 변경
=======
    public AudioSource BGM;
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c
    private BGMControl bGMControl;

    void Start()
    {
<<<<<<< HEAD
=======
        // BGMControl ��ü�� ã�� �Ҵ�
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c
        bGMControl = FindObjectOfType<BGMControl>();

        if (bGMControl != null)
        {
            if (bGMControl.BGMSwitch)
            {
<<<<<<< HEAD
                // StageClearID 값에 따라 다른 오디오 소스를 재생
                if (StageState.chooseStage == 25 || StageState.chooseStage == 45)
                {
                    if (BGM.Length > 1 && BGM[1] != null) // 두 번째 오디오 소스가 존재하는지 확인
                    {
                        BGM[1].Play();
                    }
                }
                if(StageState.chooseStage == 65)
                {
                    BGM[2].Play();
                }
                else
                {
                    if (BGM.Length > 0 && BGM[0] != null) // 첫 번째 오디오 소스가 존재하는지 확인
                    {
                        BGM[0].Play();
                    }
                    else
                    {
                        Debug.LogWarning("First audio source is missing or not assigned.");
                    }
                }
            }
            else
            {
                // 모든 오디오 소스를 멈춤
                foreach (var audioSource in BGM)
                {
                    if (audioSource != null)
                    {
                        audioSource.Stop();
                    }
                }
=======
                BGM.Play();
            }
            else
            {
                BGM.Stop();
>>>>>>> 89170a160939e0cdecdac0f1537dc9821b96b29c
            }
        }
        else
        {
            Debug.LogError("BGMControl object not found in the scene.");
        }
    }
}
