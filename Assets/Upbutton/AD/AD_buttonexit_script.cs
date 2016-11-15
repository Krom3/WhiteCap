using UnityEngine;
using System.Collections;

public class AD_buttonexit_script : MonoBehaviour {

    public AudioSource ADExitCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            ADExitCS.Play();
            if (ADUpButton_script.ADUpgradeipson == true)
            {
                ADUpButton_script.ADUpgradeipson = false;
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
