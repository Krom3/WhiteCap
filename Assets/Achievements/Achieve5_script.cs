using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achieve5_script : MonoBehaviour
{

    public static int achieveadcount = 1;
    public Text achivetext;
    // Use this for initialization
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Ad1_script.adcount >= achieveadcount)
            {
                RightBackground_script.Crystal += 1;
                achieveadcount += 1;
            }
        }
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        achivetext.text = Ad1_script.adcount + "/"+ achieveadcount;
	}
}
