using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainCharacter_script : MonoBehaviour
{
    public Sprite MainCharacter_s_C;
    public Sprite MainCharacter_s_B;
    public Sprite MainCharacter_s_A;
    public Sprite MainCharacter_s_S;
    public Sprite MainCharacter_a_C;
    public Sprite MainCharacter_a_B;
    public Sprite MainCharacter_a_A;
    public Sprite MainCharacter_a_S;
    public Sprite MainCharacter_e_C;
    public Sprite MainCharacter_e_B;
    public Sprite MainCharacter_e_A;
    public Sprite MainCharacter_e_S;
    private SpriteRenderer spriteRenderer;
    public static float jobincentive = 1;
    public static int powerincentive=0;
    public static float powerincentive2=1;
    public static float timemoneyincentive=1;
    public static float timemoneyincentive2=0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Jobyes_script.usejop == "c_salaried")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_s_C;
            jobincentive = 1.5f;
        }
        if (Jobyes_script.usejop == "b_salaried")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_s_B;
            jobincentive = 2;
        }
        if (Jobyes_script.usejop == "a_salaried")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_s_A;
            jobincentive = 3.5f;
        }
        if (Jobyes_script.usejop == "s_salaried")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_s_S;
            jobincentive = 10;
        }
        if (Jobyes_script.usejop == "c_army")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_a_C;
            powerincentive = 10;
            powerincentive2 = 1.1f;
        }
        if (Jobyes_script.usejop == "b_army")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_a_B;
            powerincentive = 30;
            powerincentive2 = 1.3f;
        }
        if (Jobyes_script.usejop == "a_army")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_a_A;
            powerincentive = 50;
            powerincentive2 = 1.7f;
        }
        if (Jobyes_script.usejop == "s_army")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_a_S;
            powerincentive = 200;
            powerincentive2 = 2f;
        }
        if (Jobyes_script.usejop == "c_entertainer")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_e_C;
            timemoneyincentive = 1.5f;
            timemoneyincentive2 = 10;
        }
        if (Jobyes_script.usejop == "b_entertainer")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_e_B;
            timemoneyincentive = 2;
            timemoneyincentive2 = 50;
        }
        if (Jobyes_script.usejop == "a_entertainer")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_e_A;
            timemoneyincentive = 3;
            timemoneyincentive2 = 300;
        }
        if (Jobyes_script.usejop == "s_entertainer")
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MainCharacter_e_S;
            timemoneyincentive = 5;
            timemoneyincentive2 = 2000;
        }
    }
}
