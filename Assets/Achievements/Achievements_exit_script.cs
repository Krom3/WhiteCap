using UnityEngine;
using System.Collections;

public class Achievements_exit_script : MonoBehaviour
{
    public GameObject text;
    public GameObject Achievements;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Acheivements_script.achievementon = false;
            text.SetActive(true);
            Achievements.SetActive(false);
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
