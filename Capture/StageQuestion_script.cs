using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageQuestion_script : MonoBehaviour
{
    public GameObject StageQuestion;
    public static bool StageQuestionoff = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (StageQuestionoff == true)
            StageQuestion.SetActive(true);
        else if (StageQuestionoff == false)
            StageQuestion.SetActive(false);

    }
}
