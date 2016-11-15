using UnityEngine;
using System.Collections;

public class Settingipsexit_script : MonoBehaviour {

    public AudioSource SettingExitCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SettingExitCS.Play();
            if (SettingUpButton_script.SettingUpgradeipson == true)
            {
                SettingUpButton_script.SettingUpgradeipson = false;
            }
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
