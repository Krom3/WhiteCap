using UnityEngine;
using System.Collections;

public class SettingUpButton_script : MonoBehaviour
{
    public GameObject SettingUpgrade_ips;
    public static bool SettingUpgradeipson;
    public Sprite SettingUpgradeipsonimg;
    public Sprite SettingUpgradeipsoffimg;
    private SpriteRenderer spriteRenderer;
    public AudioSource SettingMenuCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SettingMenuCS.Play();
            if (SettingUpgradeipson == true)
            {
                SettingUpgradeipson = false;
            }
            else if (SettingUpgradeipson == false)
            {
                SettingUpgradeipson = true;
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
                if (ADUpButton_script.ADUpgradeipson == true)
                {
                    ADUpButton_script.ADUpgradeipson = false;
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
        if (SettingUpgradeipson == true)
        {
            SettingUpgrade_ips.SetActive(SettingUpgrade_ips);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = SettingUpgradeipsonimg;
        }
        if (SettingUpgradeipson == false)
        {
            SettingUpgrade_ips.SetActive(!SettingUpgrade_ips);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = SettingUpgradeipsoffimg;
        }
    }
}
