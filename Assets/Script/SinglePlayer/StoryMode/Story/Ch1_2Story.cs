using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using TMPro;
=======
>>>>>>> 17bcf4c21ff3c9ee138a41d6376ba025b92a58b7
using UnityEngine;

public class Ch1_2Story : MonoBehaviour
{
    Ch1Story ch1Story;
<<<<<<< HEAD
    RemainTime remainTime;
    public GameObject Fadeinout;
    public GameObject RemainTime;

    void Start()
    {
        ch1Story = FindObjectOfType<Ch1Story>();
        remainTime = GetComponent<RemainTime>();
=======
    void Start()
    {
        ch1Story = FindObjectOfType<Ch1Story>();
        if(ch1Story.WatchPrologue2)
        {
            Destroy(gameObject);
        }
>>>>>>> 17bcf4c21ff3c9ee138a41d6376ba025b92a58b7
    }

    void Update()
    {
        
    }
}
