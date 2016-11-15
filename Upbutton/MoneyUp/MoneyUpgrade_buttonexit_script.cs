using UnityEngine;
using System.Collections;

public class MoneyUpgrade_buttonexit_script : MonoBehaviour
{
    public AudioSource MoneyExitCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            MoneyExitCS.Play();
            if (MoneyUpButton_script.MoneyUpgradeipson == true)
            {
                MoneyUpButton_script.MoneyUpgradeipson = false;
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
