using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achieve4_script : MonoBehaviour {

    public static int achieverevivecount = 1;
    public Text achivetext;
    // Use this for initialization
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Revive_yes.revivecount >= achieverevivecount)
            {
                RightBackground_script.Crystal += 1;
                achieverevivecount += 1;
            }
        }
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        achivetext.text = Revive_yes.revivecount + "/" + achieverevivecount;

    }
}
