using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Revive_yes : MonoBehaviour
{
    public static int revivecount=0;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RightBackground_script.Money = 0;
            LeftBackgruond_script.stageclear = 0;
            RightBackground_script.Money_TimeIncre = 0;
            RightBackground_script.Moneyincrement = 1;
            RightBackground_script.Power = 0;
            MoneyUpgrade_button1_script.Moneyupcost = 10;
            MoneyUpgrade_button1_script.Moneyupcount = 0;
            MoneyUpgrade_button1_script.Moneyuprate = 1;
            MoneyUpgrade_button1_script.Moneycostrate = 1;
            MoneyUpgrade_button1_script.Moneycostrate2 = 1;
            PowerUpgrade_button1_script.powerincre = 0;
            PowerUpgrade_button1_script.Powerupcost = 0;
            PowerUpgrade_button1_script.Powerupcount = 0;
            PowerUpgrade_button1_script.Powercostrate = 2.0f;
            JopUpgrade_button1_script.Moneyjobup = 0;
            JopUpgrade_button1_script.CrystalJobupcost = 3;
            Capture_script.endstage = 0;
            SaveGame_script.savegame();
            revivecount += 1;
            SceneManager.LoadScene("Main_scene_0_0_1");
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
}
