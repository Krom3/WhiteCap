using UnityEngine;
using System.Collections;

public class Acheivements_script : MonoBehaviour {

    public GameObject text;
    public static bool achievementon;

	// Use this for initialization
	void Start ()
    {

    }

    // Update is called once per frame
    void Update()
    {
        achievementon = true;
        text.SetActive(false);
        SettingUpButton_script.SettingUpgradeipson = false;
        StageQuestion_script.StageQuestionoff = false;
    }
}
