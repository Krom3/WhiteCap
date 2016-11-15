using UnityEngine;
using System.Collections;

public class JopUpgrade_buttonexit_script : MonoBehaviour {

    public AudioSource JobExitCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            JobExitCS.Play();
            if (JopUpButton_script.JopUpgradeipson == true)
            {
                JopUpButton_script.JopUpgradeipson = false;
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
