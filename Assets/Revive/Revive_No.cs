using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Revive_No : MonoBehaviour
{

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
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
