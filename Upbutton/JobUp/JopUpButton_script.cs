using UnityEngine;
using System.Collections;

public class JopUpButton_script : MonoBehaviour
{
    public GameObject JopUpgrade_ips;
    public static bool JopUpgradeipson;
    public Sprite JobUpgradeipsonimg;
    public Sprite JobUpgradeipsoffimg;
    private SpriteRenderer spriteRenderer;
    public AudioSource JopMenuCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Effectsound_script.effectmute == true)
            {
                JopMenuCS.Play();
            }
            if (JopUpgradeipson == true)
            {
                JopUpgradeipson = false;
            }
            else if (JopUpgradeipson == false)
            {
                JopUpgradeipson = true;
                if (MoneyUpButton_script.MoneyUpgradeipson == true)
                {
                    MoneyUpButton_script.MoneyUpgradeipson = false;
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
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (JopUpgradeipson == true)
        {
            JopUpgrade_ips.SetActive(true);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = JobUpgradeipsonimg;
        }
        if (JopUpgradeipson == false)
        {
            JopUpgrade_ips.SetActive(false);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = JobUpgradeipsoffimg;
        }
    }
}
