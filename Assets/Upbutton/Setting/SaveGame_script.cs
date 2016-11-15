using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class SaveGame_script : MonoBehaviour
{
    public AudioSource CS;

    static public void savegame()
    {
        //Money
        PlayerPrefs.SetFloat("LoadMoney", RightBackground_script.Money);
        PlayerPrefs.SetInt("LoadMincre", RightBackground_script.Moneyincrement);
        PlayerPrefs.SetInt("LoadMtimeincre", RightBackground_script.Money_TimeIncre);
        PlayerPrefs.SetInt("LoadMupcost", MoneyUpgrade_button1_script.Moneyupcost);
        PlayerPrefs.SetInt("LoadMupcount", MoneyUpgrade_button1_script.Moneyupcount);
        PlayerPrefs.SetFloat("LoadMuprate", MoneyUpgrade_button1_script.Moneyuprate);
        PlayerPrefs.SetFloat("LoadMcostrate", MoneyUpgrade_button1_script.Moneycostrate);
        PlayerPrefs.SetFloat("LoadMcostrate2", MoneyUpgrade_button1_script.Moneycostrate2);
        //crystal
        PlayerPrefs.SetInt("LoadCrystal", RightBackground_script.Crystal);
        //power
        PlayerPrefs.SetInt("LoadPower", RightBackground_script.Power);
        PlayerPrefs.SetInt("LoadPincre", PowerUpgrade_button1_script.powerincre);
        PlayerPrefs.SetInt("LoadPupcost", PowerUpgrade_button1_script.Powerupcost);
        PlayerPrefs.SetInt("LoadPupcount", PowerUpgrade_button1_script.Powerupcount);
        PlayerPrefs.SetFloat("LoadPcostrate", PowerUpgrade_button1_script.Powercostrate);
        PlayerPrefs.SetFloat("LoadPuprate", PowerUpgrade_button1_script.Poweruprate);
        PlayerPrefs.SetString("LoadPnowpower", PowerUpgrade_button1_script.nowpower);
        //jop
        PlayerPrefs.SetString("LoadJop", Jobyes_script.usejop);
        PlayerPrefs.SetInt("LoadJopup", JopUpgrade_button1_script.Moneyjobup);
        PlayerPrefs.SetFloat("LoadJopincen", MainCharacter_script.jobincentive);
        PlayerPrefs.SetInt("LoadJopchcnt", JopUpgrade_button1_script.jobchangecount);
        PlayerPrefs.SetInt("LoadJopcost", JopUpgrade_button1_script.CrystalJobupcost);
        //capture
        PlayerPrefs.SetInt("Loadend", Capture_script.endstage);
        PlayerPrefs.SetInt("Loadstage", LeftBackgruond_script.stageclear);
        PlayerPrefs.SetInt("Loadsclecnt",Capture_script.stageclearcount);
        PlayerPrefs.SetInt("LoadReverr", RightBackground_script.Resurrecscore);
        PlayerPrefs.SetInt("Loadrevive", Revive_yes.revivecount);
        //ad
        PlayerPrefs.SetInt("LoadAd",Ad1_script.adcount);
        //acheive
        PlayerPrefs.SetInt("LoadAclecnt", Achieve1_script.achieveclearcount);
        PlayerPrefs.SetFloat("LoadAMcnt", Achieve2_script.achieveMoneycount);
        PlayerPrefs.SetInt("LoadAJcnt", Achieve3_script.achieveJobchangecount);
        PlayerPrefs.SetInt("LoadARcnt", Achieve4_script.achieverevivecount);
        PlayerPrefs.SetInt("LoadAAcnt", Achieve5_script.achieveadcount);
        //
        PlayerPrefs.SetInt("Loadchangemoney", MonychangeButton.changeMoneycount);
    }
    static public void loadgame()
    {
        //Money
        RightBackground_script.Money = PlayerPrefs.GetFloat("LoadMoney");
        RightBackground_script.Moneyincrement = PlayerPrefs.GetInt("LoadMincre");
        RightBackground_script.Money_TimeIncre = PlayerPrefs.GetInt("LoadMtimeincre");
        MoneyUpgrade_button1_script.Moneyupcost = PlayerPrefs.GetInt("LoadMupcost");
        MoneyUpgrade_button1_script.Moneyupcount = PlayerPrefs.GetInt("LoadMupcount");
        MoneyUpgrade_button1_script.Moneyuprate = PlayerPrefs.GetFloat("LoadMuprate");
        MoneyUpgrade_button1_script.Moneycostrate = PlayerPrefs.GetFloat("LoadMcostrate");
        MoneyUpgrade_button1_script.Moneycostrate2 = PlayerPrefs.GetFloat("LoadMcostrate2");
        //crystal
        RightBackground_script.Crystal = PlayerPrefs.GetInt("LoadCrystal");
        //power
        RightBackground_script.Power = PlayerPrefs.GetInt("LoadPower");
        PowerUpgrade_button1_script.powerincre = PlayerPrefs.GetInt("LoadPincre");
        PowerUpgrade_button1_script.Powerupcost = PlayerPrefs.GetInt("LoadPupcost");
        PowerUpgrade_button1_script.Powerupcount = PlayerPrefs.GetInt("LoadPupcount");
        PowerUpgrade_button1_script.Powercostrate = PlayerPrefs.GetFloat("LoadPcostrate");
        PowerUpgrade_button1_script.Poweruprate = PlayerPrefs.GetFloat("LoadPuprate");
        PowerUpgrade_button1_script.nowpower = PlayerPrefs.GetString("LoadPnowpower");
        //jop
        Jobyes_script.usejop = PlayerPrefs.GetString("LoadJop");
        JopUpgrade_button1_script.Moneyjobup = PlayerPrefs.GetInt("LoadJopup");
        MainCharacter_script.jobincentive = PlayerPrefs.GetFloat("LoadJopincen");
        JopUpgrade_button1_script.jobchangecount = PlayerPrefs.GetInt("LoadJopchcnt");
        JopUpgrade_button1_script.CrystalJobupcost = PlayerPrefs.GetInt("LoadJopcost");
        //capture
        LeftBackgruond_script.stageclear = PlayerPrefs.GetInt("Loadstage");
        Capture_script.endstage = PlayerPrefs.GetInt("Loadend");
        Capture_script.stageclearcount = PlayerPrefs.GetInt("Loadsclecnt");
        RightBackground_script.Resurrecscore = PlayerPrefs.GetInt("LoadReverr");
        Revive_yes.revivecount = PlayerPrefs.GetInt("Loadrevive");
        //ad
        Ad1_script.adcount = PlayerPrefs.GetInt("LoadAd");
        //acheive
        Achieve1_script.achieveclearcount = PlayerPrefs.GetInt("LoadAclecnt");
        Achieve2_script.achieveMoneycount = PlayerPrefs.GetFloat("LoadAMcnt");
        Achieve3_script.achieveJobchangecount = PlayerPrefs.GetInt("LoadAJcnt");
        Achieve4_script.achieverevivecount = PlayerPrefs.GetInt("LoadARcnt");
        Achieve5_script.achieveadcount = PlayerPrefs.GetInt("LoadAAcnt");
        //
        MonychangeButton.changeMoneycount = PlayerPrefs.GetInt("Loadchangemoney");
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            savegame();
            CS.Play();
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
