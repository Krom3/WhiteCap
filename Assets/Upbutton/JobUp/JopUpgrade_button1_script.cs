using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JopUpgrade_button1_script : MonoBehaviour
{
    public Text JopupcostText;
    public int MoneyJobupcost = 10000000;
    public static int CrystalJobupcost = 3;
    public static int Moneyjobup = 0;
    public static int jobchangecount = 0;
    public AudioSource JobUpCS;

    void Start()
    {
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && RightBackground_script.Money >= MoneyJobupcost && Moneyjobup == 0)
        {
            JobUpCS.Play();
            RightBackground_script.Money -= MoneyJobupcost;
            Moneyjobup = 1;
            jobchangecount += 1;
            SaveGame_script.savegame();
            SceneManager.LoadScene("Jobselection_scene");

        }
        else if (Input.GetMouseButtonUp(0) && RightBackground_script.Crystal >= CrystalJobupcost && Moneyjobup == 1)
        {
            JobUpCS.Play();
            RightBackground_script.Crystal -= CrystalJobupcost;
            CrystalJobupcost += 1;
            jobchangecount += 1;
            SaveGame_script.savegame();
            SceneManager.LoadScene("Jobselection_scene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Moneyjobup == 0)
        {
            JopupcostText.text = string.Format("{0}", "비용 : " + MoneyJobupcost + " Money");
        }
        else if (Moneyjobup == 1)
        {
            JopupcostText.text = string.Format("{0}", "비용 : " + CrystalJobupcost + "Crystal");
        }
    }
}
