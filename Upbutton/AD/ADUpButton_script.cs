using UnityEngine;
using System.Collections;

public class ADUpButton_script : MonoBehaviour {

    public GameObject ADUpgrade_ips;
    public static bool ADUpgradeipson;
    public Sprite ADUpgradeipsonimg;
    public Sprite ADUpgradeipsoffimg;
    private SpriteRenderer spriteRenderer;
    public AudioSource ADMenuCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            ADMenuCS.Play();
            if (ADUpgradeipson == true)
            {
                ADUpgradeipson = false;
            }
            else if (ADUpgradeipson == false)
            {
                ADUpgradeipson = true;
                if (MoneyUpButton_script.MoneyUpgradeipson == true)
                {
                    MoneyUpButton_script.MoneyUpgradeipson = false;
                }
                if (JopUpButton_script.JopUpgradeipson == true)
                {
                    JopUpButton_script.JopUpgradeipson = false;
                }
                if (PowerUpButton_script.PowerUpgradeipson == true)
                {
                    PowerUpButton_script.PowerUpgradeipson = false;
                }
                if (SettingUpButton_script.SettingUpgradeipson == true)
                {
                    SettingUpButton_script.SettingUpgradeipson = false;
                }
            }
        }
    }
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ADUpgradeipson == true)
        {
            ADUpgrade_ips.SetActive(ADUpgrade_ips);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = ADUpgradeipsonimg;
        }
        if (ADUpgradeipson == false)
        {
            ADUpgrade_ips.SetActive(!ADUpgrade_ips);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = ADUpgradeipsoffimg;
        }
    }
}
