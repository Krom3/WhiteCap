using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class RightBackground_script : MonoBehaviour
{

    public AudioSource clicksound;
    static public float Money = 10;
    static public int Crystal = 0;
    static public int Power = 1;
    static public int Moneyincrement = 1;
    public GameObject Rightbackground_;
    static public int Money_TimeIncre;
    static public int Resurrecscore = 0;
    private float TimeCost = 2;
    private bool Exittime;
    public Text MoneyText;
    public Text CrystalText;
    public Text PowerText;
    // Use this for initialization

    /*
    /// 저장1
    /// ///////////////////////////////////////////////////////////////////////////
    public static float fTime;        //A1 일반변수
    public static int userLevel = 0;  //A2 일반변수

    [Serializable] //B 직렬화가능한 클래스
    public class PlayerData
    {
        public int userLevel;
        public float fTime;
    }


    public void SaveData()
    {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();

        //A --> B에 할당
        data.userLevel = userLevel;
        data.fTime = fTime;

        //B 직렬화하여 파일에 담기
        bf.Serialize(file, data);
        file.Close();
    }

    public void LoadData()
    {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

        if (file != null && file.Length > 0)
        {
            //파일 역직렬화하여 B에 담기
            PlayerData data = (PlayerData)bf.Deserialize(file);

            //B --> A에 할당
            userLevel = data.userLevel;
            fTime = data.fTime;

            Debug.Log(userLevel);
            Debug.Log(fTime);
        }
        else if (file == null)

        file.Close();
    }
    */
    //////////////////////////////
    /// 저장1



    void OnMouseOver()
    {
        /*
        if (Input.GetMouseButtonUp(1))
        {
            Crystal += 1;
            Power += 100000000;
        }
        */
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(2) || Input.GetMouseButtonUp(3))
        {
            if (Effectsound_script.effectmute == true)
            {
                clicksound.Play();
            }
            Money += (int)(Moneyincrement * MainCharacter_script.jobincentive); //여기에 선택된 후 코드 삽입
            MoneyUpButton_script.MoneyUpgradeipson = false;
            JopUpButton_script.JopUpgradeipson = false;
            ADUpButton_script.ADUpgradeipson = false;
            PowerUpButton_script.PowerUpgradeipson = false;
            SettingUpButton_script.SettingUpgradeipson = false;
        }
    }

    public string GetCommaText(float number)
    {
        if (Money >= 0 && Money < 10000)
        {
            return string.Format("{0:####원}", number);
        }
        else if (Money >= 10000 && Money < 100000000)
        {
            return string.Format("{0:####만####원}", number);
        }
        else if (Money >= 100000000 && Money < 1000000000000)
        {
            return string.Format("{0:####억####만}", number);
        }
        else if (Money >= 1000000000000 && Money < 10000000000000000)
        {
            return string.Format("{0:####조####억}", number);
        }
        else if (Money * 0.001 >= 1000000000000 && Money * 0.0000001 < 10000000000000000)
        {
            return string.Format("{0:####경####조}", number);
        }
        else if (Money * 0.0000001 >= 1000000000000 && Money * 0.00000000001 < 10000000000000000)
        {
            return string.Format("{0:####해####경}", number);
        }
        else
        {
            return string.Format("{0:#######################해}", number);
        }
    }
    /*
    static public string NumberFormat(float value)
    {
        float unit = 10000f;
        if (value < unit)
            return value.ToString("####");
        else
        {
            int exp = (int)(Mathf.Log(value) / Mathf.Log(unit));
            string pre = " 만억조경해";
            char[] pre2 = pre.ToCharArray();
    
            exp = Mathf.Max(exp, 0);
            exp = Mathf.Min(exp, pre2.Length-1);
    
            pre = pre2[exp].ToString();
    
            return string.Format("{0:N}{1}", value / Mathf.Pow(unit, exp), pre);
        }
        
    }
    */
    // Update is called once per frame
    void Update()
    {
        CrystalText.text = " "+Crystal;

        if (Money == 0)
            MoneyText.text = "0원";
        else if (Money > 0 && Money < 10000)
        {
            MoneyText.text = (GetCommaText(Money));
        }
        else if (Money >= 10000 && Money < 100000000)
        {
            MoneyText.text = (GetCommaText(Money));
        }
        else if (Money >= 100000000 && Money < 1000000000000)
        {
            MoneyText.text = (GetCommaText(Money * 0.0001f));
        }
        else if (Money >= 1000000000000 && Money < 10000000000000000)
        {
            MoneyText.text = (GetCommaText(Money * 0.00000001f));
        }
        else
        {
            MoneyText.text = (GetCommaText(Money * 0.000000000001f));
        }

        ///////////////////////////////////파워표시 보정
        if (PowerUpgrade_button1_script.powerincre > 0 && PowerUpgrade_button1_script.powerincre <= 100)
        {
            PowerText.text = "+" + PowerUpgrade_button1_script.powerincre;
        }
        else if (PowerUpgrade_button1_script.powerincre > 100 && PowerUpgrade_button1_script.powerincre <= 200)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 100);
        }
        else if (PowerUpgrade_button1_script.powerincre > 200 && PowerUpgrade_button1_script.powerincre <= 300)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 200);
        }
        else if (PowerUpgrade_button1_script.powerincre > 300 && PowerUpgrade_button1_script.powerincre <= 400)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 300);
        }
        else if (PowerUpgrade_button1_script.powerincre > 400 && PowerUpgrade_button1_script.powerincre <= 500)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 400);
        }
        else if (PowerUpgrade_button1_script.powerincre > 500 && PowerUpgrade_button1_script.powerincre <= 600)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 500);
        }
        else if (PowerUpgrade_button1_script.powerincre > 600 && PowerUpgrade_button1_script.powerincre <= 700)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 600);
        }
        else if (PowerUpgrade_button1_script.powerincre > 700 && PowerUpgrade_button1_script.powerincre <= 800)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 700);
        }
        else if (PowerUpgrade_button1_script.powerincre > 800 && PowerUpgrade_button1_script.powerincre <= 900)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 800);
        }
        else if (PowerUpgrade_button1_script.powerincre > 900 && PowerUpgrade_button1_script.powerincre <= 1000)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 900);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1000 && PowerUpgrade_button1_script.powerincre <= 1100)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1000);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1100 && PowerUpgrade_button1_script.powerincre <= 1200)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1100);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1200 && PowerUpgrade_button1_script.powerincre <= 1300)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1200);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1300 && PowerUpgrade_button1_script.powerincre <= 1400)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1300);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1400 && PowerUpgrade_button1_script.powerincre <= 1500)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1400);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1500 && PowerUpgrade_button1_script.powerincre <= 1600)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1500);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1600 && PowerUpgrade_button1_script.powerincre <= 1700)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1600);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1700 && PowerUpgrade_button1_script.powerincre <= 1800)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1700);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1800 && PowerUpgrade_button1_script.powerincre <= 1900)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1800);
        }
        else if (PowerUpgrade_button1_script.powerincre > 1900 && PowerUpgrade_button1_script.powerincre <= 2000)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 1900);
        }
        else if (PowerUpgrade_button1_script.powerincre > 2000 && PowerUpgrade_button1_script.powerincre <= 2100)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 2000);
        }
        else if (PowerUpgrade_button1_script.powerincre > 2100)
        {
            PowerText.text = "+" + (PowerUpgrade_button1_script.powerincre - 2100);
        }
        ///////////////////////////////////파워표시보정
        ///////////////////////////////////종료기능
        ///////////////////////////////////종료기능

        //fTime 계속 증가
        //fTime += Time.deltaTime;
    }
    void FixedUpdate()
    {
        Money += (int)((Money_TimeIncre + MainCharacter_script.timemoneyincentive2) * MainCharacter_script.timemoneyincentive);
        if (Exittime == true)
        {
            if (TimeCost > 0)
            {
                TimeCost -= Time.deltaTime;
            }
            else
            {
                TimeCost = 2;
                Exittime = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exittime = true;
            if (Input.GetKeyDown(KeyCode.Escape) && TimeCost > 0)
            {
                SaveGame_script.savegame();
                Application.Quit();
            }
        }
    }
    void Start()
    {
        SaveGame_script.loadgame();
        // LoadData();
        Acheivements_script.achievementon = false;
    }
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            SaveGame_script.savegame();
        }
    }
}