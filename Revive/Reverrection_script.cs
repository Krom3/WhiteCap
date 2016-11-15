using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reverrection_script : MonoBehaviour {

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SaveGame_script.savegame();
            SceneManager.LoadScene("revive_scene");
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
