using UnityEngine;
using System.Collections;

public class MoneyUpButton_script : MonoBehaviour {
    public GameObject MoneyUpgrade_ips;
    public static bool MoneyUpgradeipson;
    public Sprite MoneyUpgradeipsonimg;
    public Sprite MoneyUpgradeipsoffimg;
    private SpriteRenderer spriteRenderer;
    public AudioSource MoneyMenuCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Effectsound_script.effectmute == true)
            {
                MoneyMenuCS.Play();
            }
            if (MoneyUpgradeipson == true)
            {
                MoneyUpgradeipson = false;
            }
            else if (MoneyUpgradeipson == false)
            {
                MoneyUpgradeipson = true;
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
                if (SettingUpButton_script.SettingUpgradeipson == true)
                {
                    SettingUpButton_script.SettingUpgradeipson = false;
                }
            }
        }
    }
    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (MoneyUpgradeipson == true)
        {
            MoneyUpgrade_ips.SetActive(MoneyUpgrade_ips);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MoneyUpgradeipsonimg;
        }
        if (MoneyUpgradeipson == false)
        {
            MoneyUpgrade_ips.SetActive(!MoneyUpgrade_ips);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = MoneyUpgradeipsoffimg;
        }
    }
}
