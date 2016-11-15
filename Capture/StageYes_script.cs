using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageYes_script : MonoBehaviour
{
    float stagecost;
    public Text StageEntertext;

    // Use this for initialization
    void Start()
    {
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            
            if (RightBackground_script.Money >= stagecost)
            {
                RightBackground_script.Money -=stagecost;
                StageQuestion_script.StageQuestionoff = false;
                SaveGame_script.savegame();
                SceneManager.LoadScene("Capture_stage_scene");
            }
        }
    }
    public string GetCommaText(int number)
    {
        if (stagecost >= 10000 && stagecost < 100000000)
        {
            return string.Format("{0:####만}", number * 0.0001f);
        }
        else if (stagecost >= 100000000 && stagecost < 1000000000000)
        {
            return string.Format("{0:####억####만}", number * 0.0001f);
        }
        else if (stagecost >= 1000000000000 && stagecost < 10000000000000000)
        {
            return string.Format("{0:####조####억}", number * 0.0001f);
        }
        else
        {
            return string.Format("{0:#################경####조}", number);
        }
    }
    // Update is called once per frame
    void Update()
    {
        switch (Capture_script.stagenum)
        {
            case 1:
                stagecost = 100000;
                break;
            case 2:
                stagecost = 500000;
                break;
            case 3:
                stagecost = 1000000;
                break;
            case 4:
                stagecost = 5000000;
                break;
            case 5:
                stagecost = 10000000;
                break;
            case 6:
                stagecost = 30000000;
                break;
            case 7:
                stagecost = 50000000;
                break;
            case 8:
                stagecost = 70000000;
                break;
            case 9:
                stagecost = 100000000;
                break;
            case 21:
                stagecost = 1000000000;
                break;
            case 22:
                stagecost = 2000000000;
                break;
            case 23:
                stagecost = 3000000000;
                break;
            case 24:
                stagecost = 5000000000;
                break;
            case 25:
                stagecost = 7000000000;
                break;
            case 26:
                stagecost = 10000000000;
                break;
            case 27:
                stagecost = 100000000000;
                break;
            case 28:
                stagecost = 1000000000000;
                break;
            case 29:
                stagecost = 10000000000000;
                break;
        }
        StageEntertext.text = ("스테이지에 참여하시려면 " + GetCommaText((int)stagecost)  + "원이 필요합니다.");

    }
}
