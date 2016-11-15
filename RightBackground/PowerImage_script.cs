using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PowerImage_script : MonoBehaviour
{

    public Sprite book1_1;
    public Sprite book1_2;
    public Sprite book1_3;
    public Sprite book1_4;
    public Sprite book1_5;
    public Sprite book2_1;
    public Sprite book2_2;
    public Sprite book2_3;
    public Sprite book2_4;
    public Sprite book2_5;
    public Sprite book3_1;
    public Sprite book3_2;
    public Sprite book3_3;
    public Sprite book3_4;
    public Sprite book3_5;
    public Sprite book4_1;
    public Sprite book4_2;
    public Sprite book4_3;
    public Sprite book4_4;
    public Sprite book4_5;
    private SpriteRenderer spriteRenderer;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PowerUpgrade_button1_script.powerincre > 100 && PowerUpgrade_button1_script.powerincre <= 200)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book1_1;
        }
        else if (PowerUpgrade_button1_script.powerincre > 200 && PowerUpgrade_button1_script.powerincre <= 300)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book1_2;
        }
        else if (PowerUpgrade_button1_script.powerincre > 300 && PowerUpgrade_button1_script.powerincre <= 400)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book1_3;
        }
        else if (PowerUpgrade_button1_script.powerincre > 400 && PowerUpgrade_button1_script.powerincre <= 500)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book1_4;
        }
        else if (RightBackground_script.Power > 500 && RightBackground_script.Power <= 600)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book1_5;
        }
        else if (RightBackground_script.Power > 600 && RightBackground_script.Power <= 700)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book2_1;
        }
        else if (RightBackground_script.Power > 700 && RightBackground_script.Power <= 800)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book2_2;
        }
        else if (RightBackground_script.Power > 800 && RightBackground_script.Power <= 900)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book2_3;
        }
        else if (RightBackground_script.Power > 900 && RightBackground_script.Power <= 1000)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book2_4;
        }
        else if (RightBackground_script.Power > 1000 && RightBackground_script.Power <= 1100)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book2_5;
        }
        else if (RightBackground_script.Power > 1100 && RightBackground_script.Power <= 1200)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book3_1;
        }
        else if (RightBackground_script.Power > 1200 && RightBackground_script.Power <= 1300)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book3_2;
        }
        else if (RightBackground_script.Power > 1300 && RightBackground_script.Power <= 1400)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book3_3;
        }
        else if (RightBackground_script.Power > 1400 && RightBackground_script.Power <= 1500)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book3_4;
        }
        else if (RightBackground_script.Power > 1500 && RightBackground_script.Power <= 1600)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book3_5;
        }
        else if (RightBackground_script.Power > 1600 && RightBackground_script.Power <= 1700)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book4_1;
        }
        else if (RightBackground_script.Power > 1700 && RightBackground_script.Power <= 1800)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book4_2;
        }
        else if (RightBackground_script.Power > 1800 && RightBackground_script.Power <= 1900)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book4_3;
        }
        else if (RightBackground_script.Power > 1900 && RightBackground_script.Power <= 2000)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book4_4;
        }
        else if (RightBackground_script.Power > 2000)
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = book4_5;
        }
    }
}
