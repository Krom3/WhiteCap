using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUpgrade_button1_script : MonoBehaviour {
    
    public Text PowerincrementText;
    public Text PowerupcostText;
    public static int powerincre;
    public static int Powerupcost = 0;
    public static int Powerupcount = 0;
    public static string nowpower;
    public AudioSource PowerUpCS;
    public static float Poweruprate;
    public static float Powercostrate = 2.0f;

    void Start()
    {
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 100)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 1;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 1000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 200)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 2;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 5000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 300)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 3;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 10000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 400)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 4;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 25000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 500)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 5;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 50000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 600)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 6;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 100000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 700)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 7;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 200000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 800)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 8;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 400000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 900)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 9;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 750000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1000)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 10;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 1000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1100)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 12;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 5000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1200)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 14;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 10000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1300)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 16;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 25000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1400)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 18;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 50000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1500)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 20;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 100000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1600)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 22;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 200000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1700)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 24;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 400000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1800)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 26;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 750000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount < 1900)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 28;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 1000000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= Powerupcost && Powerupcount >= 1900)
        {
            PowerUpCS.Play();
            RightBackground_script.Power += 30;
            powerincre += 1;
            RightBackground_script.Money -= Powerupcost;
            Powerupcost += 2000000000;
            Powerupcount++;
            SaveGame_script.savegame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(powerincre >= 0 && powerincre <= 100)
        {
            nowpower = "기초마법학 + "+ (powerincre);
        }
        else if (powerincre > 100 && powerincre <= 200)
        {
            nowpower = "2서클입문학 + " + (powerincre -100);
        }
        else if (powerincre > 200 && powerincre <= 300)
        {
            nowpower = "2서클초급학 + " + (powerincre - 200);
        }
        else if (powerincre > 300 && powerincre <= 400)
        {
            nowpower = "2서클중급학 + " + (powerincre - 300);
        }
        else if (powerincre > 400 && powerincre <= 500)
        {
            nowpower = "2서클고급학 + " + (powerincre - 400);
        }
        else if (powerincre > 500 && powerincre <= 600)
        {
            nowpower = "2서클마스터 + " + (powerincre - 500);
        }
        else if (powerincre > 600 && powerincre <= 700)
        {
            nowpower = "4서클입문학 + " + (powerincre - 600);
        }
        else if (powerincre > 700 && powerincre <= 800)
        {
            nowpower = "4서클초급학  + " + (powerincre -700);
        }
        else if (powerincre > 800 && powerincre <= 900)
        {
            nowpower = "4서클중급학  + " + (powerincre -800);
        }
        else if (powerincre > 900 && powerincre <= 1000)
        {
            nowpower = "4서클고급학  + " + (powerincre - 900);
        }
        else if (powerincre > 1000 && powerincre <= 1100)
        {
            nowpower = "4서클마스터 + " + (powerincre - 1000);
        }
        else if (powerincre > 1100 && powerincre <= 1200)
        {
            nowpower = "6서클입문학 + " + (powerincre - 1100);
        }
        else if (powerincre > 1200 && powerincre <= 1300)
        {
            nowpower = "6서클초급학 + " + (powerincre - 1200);
        }
        else if (powerincre > 1300 && powerincre <= 1400)
        {
            nowpower = "6서클중급학 + " + (powerincre - 1300);
        }
        else if (powerincre > 1400 && powerincre <= 1500)
        {
            nowpower = "6서클고급학 + " + (powerincre - 1400);
        }
        else if (powerincre > 1500 && powerincre <= 1600)
        {
            nowpower = "6서클마스터 + " + (powerincre - 1500);
        }
        else if (powerincre > 1600 && powerincre <= 1700)
        {
            nowpower = "8서클입문학 + " + (powerincre - 1600);
        }
        else if (powerincre > 1700 && powerincre <= 1800)
        {
            nowpower = "8서클초급학 + " + (powerincre - 1700);
        }
        else if (powerincre > 1800 && powerincre <= 1900)
        {
            nowpower = "8서클중급학 + " + (powerincre - 1800);
        }
        else if (powerincre > 1900 && powerincre <= 2000)
        {
            nowpower = "8서클고급학 + " + (powerincre - 1900);
        }
        else if (powerincre > 2000)
        {
            nowpower = "8서클마스터 + " + (powerincre - 2000);
        }

        PowerupcostText.text = string.Format("{0}", "업그레이드 비용 : " + Powerupcost);
        PowerincrementText.text = string.Format("{0}", nowpower);
    }
}
