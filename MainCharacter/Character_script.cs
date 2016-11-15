using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Character_script : MonoBehaviour
{

    public float LTextBoxCool = 10f;
    public float LTextBoxCool2 = 4f;
    public float RTextBoxCool = 13f;
    public float RTextBoxCool2 = 3f;
    public GameObject Talkbox1;
    public GameObject Talkbox2;
    public GameObject reverrrr;
    public Text Ltext;
    public Text Rtext;
    //public Text JobNameText;
    //public Text JobClassText;
    //JobNameText.text = string.Format("{0}", "직업 : 회사원");
    //JobClassText.text = string.Format("{0}", "등급 : C");

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //왜 잘생겨지는 마법은 없냐능.. 치킨 '한조각'?
        if (Jobyes_script.usejop == "c_salaried")
        {
            Ltext.text = string.Format("{0}", "퇴근은 언제하지?...");
            Rtext.text = string.Format("{0}", "힘들다...");
        }
        else if (Jobyes_script.usejop == "b_salaried")
        {
            Ltext.text = string.Format("{0}", "새로운 Idea가 필요해!!");
            Rtext.text = string.Format("{0}", "커피마실까?");
        }
        else if (Jobyes_script.usejop == "a_salaried")
        {
            Ltext.text = string.Format("{0}", "오늘 끝나고 회식각인가?");
            Rtext.text = string.Format("{0}", "아무생각이없다");
        }
        else if (Jobyes_script.usejop == "s_salaried")
        {
            Ltext.text = string.Format("{0}", "Show Me The Money!!");
            Rtext.text = string.Format("{0}", "난 돈이 좋아!");
        }
        else if (Jobyes_script.usejop == "c_army")
        {
            Ltext.text = string.Format("{0}", "난 누↗군↘가 여↗긴 어↘딘가");
            Rtext.text = string.Format("{0}", "시간이 안가..");
        }
        else if (Jobyes_script.usejop == "b_army")
        {
            Ltext.text = string.Format("{0}", "아 진급하고   싶다..");
            Rtext.text = string.Format("{0}", "통신보안");
        }
        else if (Jobyes_script.usejop == "a_army")
        {
            Ltext.text = string.Format("{0}", "병사는 나의    일꾼~");
            Rtext.text = string.Format("{0}", "1q2w3e4r!");
        }
        else if (Jobyes_script.usejop == "s_army")
        {
            Ltext.text = string.Format("{0}", "지피지기면 백전백승!");
            Rtext.text = string.Format("{0}", "디시즈스파르타");
        }
        else if (Jobyes_script.usejop == "c_entertainer")
        {
            Ltext.text = string.Format("{0}", "연습생좀 그만하고싶다..");
            Rtext.text = string.Format("{0}", "사인 연습해야지");
        }
        else if (Jobyes_script.usejop == "b_entertainer")
        {
            Ltext.text = string.Format("{0}", "너무 반짝반짝 눈이 부셔~");
            Rtext.text = string.Format("{0}", "That's No No");
        }
        else if (Jobyes_script.usejop == "a_entertainer")
        {
            Ltext.text = string.Format("{0}", "팬 여러분 덕분입니다.");
            Rtext.text = string.Format("{0}", "난 너무 멋있어");
        }
        else if (Jobyes_script.usejop == "s_entertainer")
        {
            Ltext.text = string.Format("{0}", "윰마 하하하드 브레이커~");
            Rtext.text = string.Format("{0}", "It's DG Style");
        }
        else
        {
            Ltext.text = string.Format("{0}", "왜 잘생겨지는 마법은 없냐능..");
            Rtext.text = string.Format("{0}", "치킨 '한조각'?");
        }
        if (Capture_script.endstage == 1)
            reverrrr.SetActive(true);
        else
            reverrrr.SetActive(false);

    }
    void FixedUpdate()
    {
        if (MoneyUpButton_script.MoneyUpgradeipson == false && JopUpButton_script.JopUpgradeipson == false && ADUpButton_script.ADUpgradeipson == false && PowerUpButton_script.PowerUpgradeipson == false && SettingUpButton_script.SettingUpgradeipson == false && Acheivements_script.achievementon == false)
        {
            LTextBoxCool -= Time.deltaTime;
            RTextBoxCool -= Time.deltaTime;
        }

        if (LTextBoxCool < 0)
        {
            Talkbox1.SetActive(true);
            LTextBoxCool2 -= Time.deltaTime;
            if (LTextBoxCool2 < 0 || MoneyUpButton_script.MoneyUpgradeipson == true || JopUpButton_script.JopUpgradeipson == true || ADUpButton_script.ADUpgradeipson == true || PowerUpButton_script.PowerUpgradeipson == true || SettingUpButton_script.SettingUpgradeipson == true || Acheivements_script.achievementon == true)
            {
                Talkbox1.SetActive(false);
                LTextBoxCool = 10f;
                LTextBoxCool2 = 4f;
            }
        }
        if (RTextBoxCool < 0)
        {
            Talkbox2.SetActive(true);
            RTextBoxCool2 -= Time.deltaTime;
            if (RTextBoxCool2 < 0 || MoneyUpButton_script.MoneyUpgradeipson == true || JopUpButton_script.JopUpgradeipson == true || ADUpButton_script.ADUpgradeipson == true || PowerUpButton_script.PowerUpgradeipson == true || SettingUpButton_script.SettingUpgradeipson == true)
            {
                Talkbox2.SetActive(false);
                RTextBoxCool = 15f;
                RTextBoxCool2 = 3f;
            }
        }
    }
}
