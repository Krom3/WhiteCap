using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jobrandomize_script : MonoBehaviour
{

    public Text JobNameText;
    public Text JobClassText;
    public Text JobOptionviewText;
    public static string showjop;
    int jobrandom_pbt;


    // Use this for initialization
    void Start()
    {
            jobrandom_pbt = Random.Range(0, 3150 + (45 * (RightBackground_script.Resurrecscore)));
        //salareid
        if (0 <= jobrandom_pbt && 800 + (15 * RightBackground_script.Resurrecscore) > jobrandom_pbt)
        {
            showjop = "c_salaried";
            JobNameText.text = string.Format("{0}", "직업 : 회사원");
            JobClassText.text = string.Format("{0}", "등급 : C");
            JobOptionviewText.text = string.Format("{0}", "클릭시 수입이 아주 조~금 늘어난다.");
        }
        if (2400 + (15 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 2600 + (15 * RightBackground_script.Resurrecscore) > jobrandom_pbt)
        {
            showjop = "b_salaried";
            JobNameText.text = string.Format("{0}", "직업 : 회사원");
            JobClassText.text = string.Format("{0}", "등급 : B");
            JobOptionviewText.text = string.Format("{0}", "클릭시 수입이 약~간 늘어난다.");
        }
        if (3000 + (15 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 3050 + (10 * RightBackground_script.Resurrecscore) > jobrandom_pbt && RightBackground_script.Resurrecscore>0)
        {
            showjop = "a_salaried";
            JobNameText.text = string.Format("{0}", "직업 : 회사원");
            JobClassText.text = string.Format("{0}", "등급 : A");
            JobOptionviewText.text = string.Format("{0}", "클릭시 수입이 '꽤' 늘어난다.");
        }
        if (3150 + (10 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 3160 + (5 * RightBackground_script.Resurrecscore) > jobrandom_pbt && RightBackground_script.Resurrecscore > 1)
        {
            showjop = "s_salaried";
            JobNameText.text = string.Format("{0}", "직업 : 회사원");
            JobClassText.text = string.Format("{0}", "등급 : S");
            JobOptionviewText.text = string.Format("{0}", "클릭시 수입이 존X 늘어난다.");
        }
        //army
        if (800 + (15 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 1600 + (15 * RightBackground_script.Resurrecscore) > jobrandom_pbt)
        {
            showjop = "c_army";
            JobNameText.text = string.Format("{0}", "직업 : 군인");
            JobClassText.text = string.Format("{0}", "등급 : C");
            JobOptionviewText.text = string.Format("{0}", "마법위력이 아주 조~금 증가한다.");
        }
        if (2600 + (15 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 2800 + (15 * RightBackground_script.Resurrecscore) > jobrandom_pbt)
        {
            showjop = "b_army";
            JobNameText.text = string.Format("{0}", "직업 : 군인");
            JobClassText.text = string.Format("{0}", "등급 : B");
            JobOptionviewText.text = string.Format("{0}", "마법위력이 약~간 증가한다.");
        }
        if (3050 + (10 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 3100 + (10 * RightBackground_script.Resurrecscore) > jobrandom_pbt && RightBackground_script.Resurrecscore > 0)
        {
            showjop = "a_army";
            JobNameText.text = string.Format("{0}", "직업 : 군인");
            JobClassText.text = string.Format("{0}", "등급 : A");
            JobOptionviewText.text = string.Format("{0}", "마법위력이 어느정도 증가한다.");
        }
        if (3160 + (5 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 3170 + (5 * RightBackground_script.Resurrecscore) > jobrandom_pbt && RightBackground_script.Resurrecscore > 0)
        {
            showjop = "s_army";
            JobNameText.text = string.Format("{0}", "직업 : 군인");
            JobClassText.text = string.Format("{0}", "등급 : S");
            JobOptionviewText.text = string.Format("{0}", "마법위력이 '꽤' 증가한다.");
        }
        //entertainer
        if (1600 + (15 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 2400 + (15 * RightBackground_script.Resurrecscore) > jobrandom_pbt)
        {
            showjop = "c_entertainer";
            JobNameText.text = string.Format("{0}", "직업 : 연예인");
            JobClassText.text = string.Format("{0}", "등급 : C");
            JobOptionviewText.text = string.Format("{0}", "점령지 수입이 아주 조~금 증가한다.");
        }
        if (2800 + (15 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 3000 + (15 * RightBackground_script.Resurrecscore) > jobrandom_pbt)
        {
            showjop = "b_entertainer";
            JobNameText.text = string.Format("{0}", "직업 : 연예인");
            JobClassText.text = string.Format("{0}", "등급 : B");
            JobOptionviewText.text = string.Format("{0}", "점령지 수입이 약~간 증가한다.");
        }
        if (3100 + (10 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 3150 + (10 * RightBackground_script.Resurrecscore) > jobrandom_pbt && RightBackground_script.Resurrecscore > 0)
        {
            showjop = "a_entertainer";
            JobNameText.text = string.Format("{0}", "직업 : 연예인");
            JobClassText.text = string.Format("{0}", "등급 : A");
            JobOptionviewText.text = string.Format("{0}", "점령지 수입이 어느정도 증가한다.");
        }
        if (3170 + (5 * RightBackground_script.Resurrecscore) <= jobrandom_pbt && 3180 + (5 * RightBackground_script.Resurrecscore) > jobrandom_pbt && RightBackground_script.Resurrecscore > 0)
        {
            showjop = "s_entertainer";
            JobNameText.text = string.Format("{0}", "직업 : 연예인");
            JobClassText.text = string.Format("{0}", "등급 : S");
            JobOptionviewText.text = string.Format("{0}", "점령지 수입이 '꽤' 증가한다.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
