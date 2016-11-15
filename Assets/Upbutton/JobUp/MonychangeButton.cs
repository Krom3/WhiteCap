using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MonychangeButton : MonoBehaviour
{
    public Text JopupcostText;
    public float changeMoney;
    public static int changeMoneycount = 1;
    public AudioSource JobUpCS;

    void Start()
    {
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && RightBackground_script.Crystal >= 1)
        {
            RightBackground_script.Money += changeMoney;
            RightBackground_script.Crystal -= 1;
            changeMoneycount += 1;
            JobUpCS.Play();
            SaveGame_script.savegame();
        }
    }
    public string GetCommaText(float number)
    {
        if (changeMoney >= 10000 && changeMoney < 100000000)
        {
            return string.Format("{0:####만}", number * 0.0001f);
        }
        else if (changeMoney >= 100000000 && changeMoney * 0.001 < 1000000000)
        {
            return string.Format("{0:####억####만}", number * 0.0001f);
        }
        else if (changeMoney * 0.001 >= 1000000000 && changeMoney * 0.000001 < 10000000000)
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
        changeMoney = (PowerUpgrade_button1_script.Powerupcost*5)+(MoneyUpgrade_button1_script.Moneyupcost*5) +((RightBackground_script.Power * 5)*500) + ((MoneyUpgrade_button1_script.Moneyupcount * 3)*500) + ((changeMoneycount * changeMoneycount * 10) * 500);
        JopupcostText.text = string.Format("{0}", "+ " + GetCommaText(changeMoney));
    }
}
