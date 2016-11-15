using UnityEngine;
using System.Collections;

public class PowerUpgrade_buttonexit_script : MonoBehaviour
{
    public AudioSource PowerExitCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            PowerExitCS.Play();
            if (PowerUpButton_script.PowerUpgradeipson == true)
            {
                PowerUpButton_script.PowerUpgradeipson = false;
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
