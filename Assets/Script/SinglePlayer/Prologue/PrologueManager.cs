using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;

public class PrologueManager : MonoBehaviour
{
    public Image firstImage;
    public Image secondImage;

    void Start()
    {
        StartCoroutine(FadeInAndOut(firstImage));
    }

    IEnumerator FadeInAndOut(Image image)
    {
        for (float alpha = 0; alpha <= 1; alpha += Time.deltaTime * 0.5f)
        {
            SetImageAlpha(image, alpha);
            yield return null;
        }
        SetImageAlpha(image, 1);

        yield return new WaitForSeconds(1);
        for (float alpha = 1; alpha >= 0; alpha -= Time.deltaTime * 0.5f)
        {
            SetImageAlpha(image, alpha);
            yield return null;
        }
        SetImageAlpha(image, 0);
        image.gameObject.SetActive(false);
        secondImage.gameObject.SetActive(true);

        yield return new WaitForSeconds(4.5f);

        AudioSource audioSource = secondImage.GetComponent<AudioSource>();
        if (audioSource != null)
        {
            TextManager textManager = FindObjectOfType<TextManager>();
            audioSource.Stop();
            textManager.GiveMeTextId(1);
        }
    }

    void SetImageAlpha(Image image, float alpha)
    {
        Color color = image.color;
        color.a = alpha;
        image.color = color;
    }
}
=======

public class PrologueManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
>>>>>>> 04fec377b2d05bb9fa9bbe0e64030911b4f22d59
