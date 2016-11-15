using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Jobyes_script : MonoBehaviour
{
    public static string usejop;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            usejop = Jobrandomize_script.showjop;
            SaveGame_script.savegame();
            SceneManager.LoadScene("Main_scene_0_0_1");
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
