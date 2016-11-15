using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Capture_script : MonoBehaviour
{
    public AudioSource click;
    public AudioSource clear;
    public AudioSource timer;
    public int Capturehp;
    public int Capturehp_half;
    public GameObject capture1_obj;
    private SpriteRenderer spriteRenderer;
    public static int stagenum;
    public Text Timer_text;
    public Text CaptureNameText;
    public float TimeCost = 6;
    public static int endstage = 0;
    public static int stageclearcount=0;
    public GameObject guitextct;

    //스프라이트
    public Sprite None;
    public Sprite Chapter1_1;
    public Sprite Chapter1_2;
    public Sprite Chapter1_3;
    public Sprite Chapter1_4;
    public Sprite Chapter1_5;
    public Sprite Chapter1_6;
    public Sprite Chapter1_7;
    public Sprite Chapter1_8;
    public Sprite Chapter1_9;
    public Sprite Chapter2_1;
    public Sprite Chapter2_2;
    public Sprite Chapter2_3;
    public Sprite Chapter2_4;
    public Sprite Chapter2_5;
    public Sprite Chapter2_6;
    public Sprite Chapter2_7;
    public Sprite Chapter2_8;
    public Sprite Chapter2_9;
    public int justone=1;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            click.Play();
            Capturehp -= (int)((RightBackground_script.Power + MainCharacter_script.powerincentive) * MainCharacter_script.powerincentive2);
        }
    }
    // Use this for initialization
    void Start()
    {
        timer.Play();
        ////////////////////////////////////////////
        ////////////////////Chapter1////////////////
        ////////////////////////////////////////////
        if (stagenum == 1)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_1;
            Capturehp = 300;
            CaptureNameText.text = "전라남도 - 여수엑스포";
        }
        else if (stagenum == 2)
        {
            Capturehp = 1200;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_2;
            CaptureNameText.text = "경상남도 - 사직야구장";
        }
        else if (stagenum == 3)
        {
            Capturehp = 3000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_3;
            CaptureNameText.text = "경상북도 - 첨성대";
        }
        else if (stagenum == 4)
        {
            Capturehp = 5000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_4;
            CaptureNameText.text = "전라북도 - 전주한옥마을";
        }
        else if (stagenum == 5)
        {
            Capturehp = 9000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_5;
            CaptureNameText.text = "충청남도 - 논산훈련소";
        }
        else if (stagenum == 6)
        {
            Capturehp = 18000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_6;
            CaptureNameText.text = "충청북도 - 청풍문화재단지";
        }
        else if (stagenum == 7)
        {
            Capturehp = 30000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_7;
            CaptureNameText.text = "강원도 - 오죽헌";
        }
        else if (stagenum == 8)
        {
            Capturehp = 70000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_8;
            CaptureNameText.text = "경기도 - 수원화성";
        }
        else if (stagenum == 9)
        {
            Capturehp = 100000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter1_9;
            CaptureNameText.text = "서울특별시 - 청와대";
        }
        ////////////////////////////////////////////
        ////////////////////Chapter2////////////////
        ////////////////////////////////////////////
        else if (stagenum == 21)
        {
            Capturehp = 500;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_1;
            CaptureNameText.text = "일본 - 오사카성";
        }
        else if (stagenum == 22)
        {
            Capturehp = 3000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_2;
            CaptureNameText.text = "터키 - 소피아성당";
        }
        else if (stagenum == 23)
        {
            Capturehp = 10000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_3;
            CaptureNameText.text = "독일 - 개선문";
        }
        else if (stagenum == 24)
        {
            Capturehp = 50000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_4;
            CaptureNameText.text = "프랑스 - 에펠탑";
        }
        else if (stagenum == 25)
        {
            Capturehp = 200000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_5;
            CaptureNameText.text = "영국 - 빅 벤";
        }
        else if (stagenum == 26)
        {
            Capturehp = 800000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_6;
            CaptureNameText.text = "인도 - 코끼리";
        }
        else if (stagenum == 27)
        {
            Capturehp = 2000000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_7;
            CaptureNameText.text = "중국 - 만리장성";
        }
        else if (stagenum == 28)
        {
            Capturehp = 10000000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_8;
            CaptureNameText.text = "러시아 - 바실리성당";
        }
        else if (stagenum == 29)
        {
            Capturehp = 10000000;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Chapter2_9;
            CaptureNameText.text = "미국 - 자유의여신상";
        }
        ////////////////////////////////////////////
        ////////////////////Chapter3////////////////
        ////////////////////////////////////////////
        else if (stagenum == 31)
        {
            Capturehp = 500;
        }
        else if (stagenum == 32)
        {
            Capturehp = 3000;
        }
        else if (stagenum == 33)
        {
            Capturehp = 10000;
        }
        else if (stagenum == 34)
        {
            Capturehp = 50000;
        }
        else if (stagenum == 35)
        {
            Capturehp = 200000;
        }
        else if (stagenum == 36)
        {
            Capturehp = 800000;
        }
        else if (stagenum == 37)
        {
            Capturehp = 2000000;
        }
        else if (stagenum == 38)
        {
            Capturehp = 10000000;
        }
        else if (stagenum == 39)
        {
            Capturehp = 10000000;
        }

    }

    // Update is called once per frame
    void Update()
    {

        TimeCost -= Time.deltaTime;
        Timer_text.text = string.Format("{0}", "남은시간:" + (int)TimeCost);

        if (Effectsound_script.effectmute == false)
        {
            click.volume = 0;
            timer.volume = 0;
            clear.volume = 0;
        }
        else if (Effectsound_script.effectmute == true)
        {
            click.volume = 1;
            timer.volume = 1;
            clear.volume = 1;
        }

        if (TimeCost < 1)
        {
            SaveGame_script.savegame();
            SceneManager.LoadScene("Main_scene_0_0_1");
        }

        if (Capturehp <= 0 && justone == 1)
        {
            stageclearcount += 1;

            if (Effectsound_script.effectmute == false)
            {
                click.volume = 0;
                timer.volume = 0;
                clear.volume = 0;
            }
            else if (Effectsound_script.effectmute == true)
            {
                click.volume = 1;
                timer.volume = 1;
                clear.volume = 1;
            }
            RightBackground_script.Crystal += 1;
            TimeCost = 2.5f;
            clear.PlayDelayed(0.5f);
            timer.Stop();
            guitextct.SetActive(!guitextct);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = None;
            if (stagenum == 1)
            {
                //Capture1button_script.stage1_clear = true;
                LeftBackgruond_script.stageclear = 1;
                RightBackground_script.Money_TimeIncre = 10;
            }
            else if (stagenum == 2)
            {
                //Capture2button_script.stage2_clear = true;
                LeftBackgruond_script.stageclear = 2;
                RightBackground_script.Money_TimeIncre = 50;
            }
            else if (stagenum == 3)
            {
                //Capture3button_script.stage3_clear = true;
                LeftBackgruond_script.stageclear = 3;
                RightBackground_script.Money_TimeIncre = 300;
            }
            else if (stagenum == 4)
            {
                //Capture4button_script.stage4_clear = true;
                LeftBackgruond_script.stageclear = 4;
                RightBackground_script.Money_TimeIncre = 2000;
            }
            else if (stagenum == 5)
            {
                //Capture5button_script.stage5_clear = true;
                LeftBackgruond_script.stageclear = 5;
                RightBackground_script.Money_TimeIncre = 8000;
            }
            else if (stagenum == 6)
            {
                //Capture6button_script.stage6_clear = true;
                LeftBackgruond_script.stageclear = 6;
                RightBackground_script.Money_TimeIncre = 35000;
            }
            else if (stagenum == 7)
            {
                //Capture7button_script.stage7_clear = true;
                LeftBackgruond_script.stageclear = 7;
                RightBackground_script.Money_TimeIncre = 150000;
            }
            else if (stagenum == 8)
            {
                //Capture8button_script.stage8_clear = true;
                LeftBackgruond_script.stageclear = 8;
                RightBackground_script.Money_TimeIncre = 5000000;
            }
            else if (stagenum == 9)
            {
                //Capture9button_script.stage9_clear = true;
                LeftBackgruond_script.stageclear = 9;
                RightBackground_script.Money_TimeIncre = 2000000;
            }
            else if (stagenum == 21)
            {
                //Capture1button2_script.stage21_clear = true;
                LeftBackgruond_script.stageclear = 21;
                RightBackground_script.Money_TimeIncre = 10;
            }
            else if (stagenum == 22)
            {
                //Capture2button2_script.stage22_clear = true;
                LeftBackgruond_script.stageclear = 22;
                RightBackground_script.Money_TimeIncre = 50;
            }
            else if (stagenum == 23)
            {
                //Capture3button2_script.stage23_clear = true;
                LeftBackgruond_script.stageclear = 23;
                RightBackground_script.Money_TimeIncre = 300;
            }
            else if (stagenum == 24)
            {
                //Capture4button2_script.stage24_clear = true;
                LeftBackgruond_script.stageclear = 24;
                RightBackground_script.Money_TimeIncre = 2000;
            }
            else if (stagenum == 25)
            {
                //Capture5button2_script.stage25_clear = true;
                LeftBackgruond_script.stageclear = 25;
                RightBackground_script.Money_TimeIncre = 8000;
            }
            else if (stagenum == 26)
            {
                //Capture6button2_script.stage26_clear = true;
                LeftBackgruond_script.stageclear = 26;
                RightBackground_script.Money_TimeIncre = 35000;
            }
            else if (stagenum == 27)
            {
                //Capture7button2_script.stage27_clear = true;
                LeftBackgruond_script.stageclear = 27;
                RightBackground_script.Money_TimeIncre = 150000;
            }
            else if (stagenum == 28)
            {
                //Capture8button2_script.stage28_clear = true;
                LeftBackgruond_script.stageclear = 28;
                RightBackground_script.Money_TimeIncre = 5000000;
            }
            else if (stagenum == 29)
            {
                //Capture9button2_script.stage29_clear = true;
                LeftBackgruond_script.stageclear = 29;
                RightBackground_script.Money_TimeIncre = 2000000;
                endstage = 1;
            }
            else if (stagenum == 31)
            {
                //Capture1button_script.stage1_clear = true;
                LeftBackgruond_script.stageclear = 31;
                RightBackground_script.Money_TimeIncre = 10;
            }
            else if (stagenum == 32)
            {
                //Capture2button_script.stage2_clear = true;
                LeftBackgruond_script.stageclear = 32;
                RightBackground_script.Money_TimeIncre = 50;
            }
            else if (stagenum == 33)
            {
                //Capture3button_script.stage3_clear = true;
                LeftBackgruond_script.stageclear = 33;
                RightBackground_script.Money_TimeIncre = 300;
            }
            else if (stagenum == 34)
            {
                //Capture4button_script.stage4_clear = true;
                LeftBackgruond_script.stageclear = 34;
                RightBackground_script.Money_TimeIncre = 2000;
            }
            else if (stagenum == 35)
            {
                //Capture5button_script.stage5_clear = true;
                LeftBackgruond_script.stageclear = 35;
                RightBackground_script.Money_TimeIncre = 8000;
            }
            else if (stagenum == 36)
            {
                //Capture6button_script.stage6_clear = true;
                LeftBackgruond_script.stageclear = 36;
                RightBackground_script.Money_TimeIncre = 35000;
            }
            else if (stagenum == 37)
            {
                //Capture7button_script.stage7_clear = true;
                LeftBackgruond_script.stageclear = 37;
                RightBackground_script.Money_TimeIncre = 150000;
            }
            else if (stagenum == 38)
            {
                //Capture8button_script.stage8_clear = true;
                LeftBackgruond_script.stageclear = 38;
                RightBackground_script.Money_TimeIncre = 5000000;
            }
            else if (stagenum == 39)
            {
                //Capture9button_script.stage9_clear = true;
                LeftBackgruond_script.stageclear = 39;
                RightBackground_script.Money_TimeIncre = 2000000;
            }
            justone++;
        }
    }
}