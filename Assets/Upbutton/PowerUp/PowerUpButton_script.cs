using UnityEngine;
using System.Collections;

public class PowerUpButton_script : MonoBehaviour
{
    public GameObject PowerUpgrade_ips;
    public static bool PowerUpgradeipson;
    public Sprite PowerUpgradeipsonimg;
    public Sprite PowerUpgradeipsoffimg;
    private SpriteRenderer spriteRenderer;
    public AudioSource PowerMenuCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            PowerMenuCS.Play();
            if (PowerUpgradeipson == true)
            {
                PowerUpgradeipson = false;
            }
            else if (PowerUpgradeipson == false)
            {
                PowerUpgradeipson = true;
                if (MoneyUpButton_script.MoneyUpgradeipson == true)
                {
                    MoneyUpButton_script.MoneyUpgradeipson = false;
                }
                if (JopUpButton_script.JopUpgradeipson == true)
                {
                    JopUpButton_script.JopUpgradeipson = false;
                }
                if (ADUpButton_script.ADUpgradeipson == true)
                {
                    ADUpButton_script.ADUpgradeipson = false;
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
        if (PowerUpgradeipson == true)
        {
            PowerUpgrade_ips.SetActive(PowerUpgrade_ips);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = PowerUpgradeipsonimg;
        }
        if (PowerUpgradeipson == false)
        {
            PowerUpgrade_ips.SetActive(!PowerUpgrade_ips);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = PowerUpgradeipsoffimg;
        }
    }
}
