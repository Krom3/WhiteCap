using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftBackgruond_script : MonoBehaviour
{

    public Text ChapterText;
    public static int Chapternum = 1;
    public GameObject Beforearrow;
    public GameObject Nextarrow;
    public GameObject Chapter1_obj;
    public GameObject Chapter2_obj;
    public GameObject Chapter3_obj;
    public Sprite basicstage2;
    public static Sprite basicstage;
    //스테이지 클리어 확인함수
    public static int stageclear;
    // Use this for initialization
    public int stageclear2;
    void Start()
    {
        basicstage = basicstage2;
    }
    // Update is called once per frame
    void Update()
    {
        stageclear2 = stageclear;
        ChapterText.text = "Chapter:" + Chapternum;
        if (Chapternum == 1)
        {
            Beforearrow.SetActive(!Beforearrow);
            Chapter1_obj.SetActive(true);
        }
        else
        {
            Beforearrow.SetActive(Beforearrow);
            Chapter1_obj.SetActive(false);
        }
        if (Chapternum == 2)
        {
            Nextarrow.SetActive(!Nextarrow);
            Chapter2_obj.SetActive(true);
        }
        else
        {
            Nextarrow.SetActive(Nextarrow);
            Chapter2_obj.SetActive(false);
        }


    }
}
