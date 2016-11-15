using UnityEngine;
using System.Collections;

public class exit_script : MonoBehaviour {
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            PlayerPrefs.SetInt("LoadMoney", (int)RightBackground_script.Money);
            Application.Quit();
        }
    }
    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
