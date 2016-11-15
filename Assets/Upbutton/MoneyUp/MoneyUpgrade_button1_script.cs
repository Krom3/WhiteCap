using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyUpgrade_button1_script : MonoBehaviour
{
    public Text MoneyincrementText;
    public Text MoenyupcostText;
    public Text MoneyfinalincrementText;
    public static int Moneyupcost = 10;
    public static int Moneyupcount = 0;
    public AudioSource MoneyUpCS;
    public static float Moneyuprate = 1;
    public static float Moneycostrate = 1;
    public static float Moneycostrate2 = 1;

    void Start()
    {
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Moneyupcost)
        {
            MoneyUpCS.Play();

            RightBackground_script.Moneyincrement += (int)Moneyuprate;
            Moneyuprate += 1;
            RightBackground_script.Money -= Moneyupcost;

            Moneycostrate2 += 0.001f;
            Moneycostrate2 = 1.1f;
            Moneycostrate *= Moneycostrate2;
            Moneyupcost += (int)(Moneycostrate);
            Moneyupcount++;
            SaveGame_script.savegame();
            /*  RightBackground_script.Moneyincrement += (int)(Moneyuprate);
              RightBackground_script.Money -= Moneyupcost;

              Moneycostrate += Moneycostrate * Moneycostrate2;
              Moneycostrate2 = ;
              Moneycostrate2 += ;
              Moneyupcost = (int)(Moneycostrate);
            /*
          }
          /*
          else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Moneyupcost && Moneyupcount < 50)
          {
              MoneyUpCS.Play();
              RightBackground_script.Moneyincrement += 10;
              RightBackground_script.Money -= Moneyupcost;
              Moneyupcost += 200;
              Moneyupcount++;
          }
          else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Moneyupcost && Moneyupcount < 100)
          {
              MoneyUpCS.Play();
              RightBackground_script.Moneyincrement += 10;
              RightBackground_script.Money -= Moneyupcost;
              Moneyupcost += 500;
              Moneyupcount++;
          }
          else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Moneyupcost && Moneyupcount < 500)
          {
              MoneyUpCS.Play();
              RightBackground_script.Moneyincrement += 10;
              RightBackground_script.Money -= Moneyupcost;
              Moneyupcost += 1000;
              Moneyupcount++;
          }
          else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Moneyupcost && Moneyupcount >=500)
          {
              MoneyUpCS.Play();
              RightBackground_script.Moneyincrement += 10;
              RightBackground_script.Money -= Moneyupcost;
              Moneyupcost += 1000;
              Moneyupcount++;
          }
          */
        }
    }


    // Update is called once per frame
    void Update()
    {
        MoenyupcostText.text = string.Format("{0}", "업그레이드 비용 : " + Moneyupcost);
        MoneyincrementText.text = string.Format("{0}", "업그레이드 횟수 : " + Moneyupcount);
        MoneyfinalincrementText.text = string.Format("{0}", "클릭 시 수입 : " + (int)(RightBackground_script.Moneyincrement * MainCharacter_script.jobincentive));
    }
}
