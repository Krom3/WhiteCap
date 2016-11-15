using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achieve2_script : MonoBehaviour
{
    public static float achieveMoneycount = 1000000000;
    public Text achivetext;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (RightBackground_script.Money >= achieveMoneycount)
            { RightBackground_script.Crystal += 1;
                achieveMoneycount = achieveMoneycount * 10;
            }
        }
    }
    // Use this for initialization
    void Start () {
	
	}

    public string GetCommaText(float number)
    {
        if (achieveMoneycount >= 10000 && achieveMoneycount < 100000000)
        {
            return string.Format("{0:####만원}", number * 0.0001f);
        }
        else if (achieveMoneycount >= 100000000 && achieveMoneycount < 1000000000000)
        {
            return string.Format("{0:####억원}", number * 0.00000001f);
        }
        else if (achieveMoneycount >= 1000000000000 && achieveMoneycount < 10000000000000000)
        {
            return string.Format("{0:####조원}", number * 0.000000000001f);
        }
        else if (achieveMoneycount >= 10000000000000000 && achieveMoneycount * 0.1f < 10000000000000000000)
        {
            return string.Format("{0:####경원}", number * 0.0000000000000001f);
        }
        else if (achieveMoneycount * 0.0001f >= 10000000000000000 && achieveMoneycount * 0.00001f < 10000000000000000000)
        {
            return string.Format("{0:####해원}", number * 0.00000000000000000001f);
        }
        else
            return string.Format(number* 0.00000000000000000001f+"해원");            
    }

    // Update is called once per frame
    void Update ()
    {
        achivetext.text = GetCommaText(achieveMoneycount);
    }
}
