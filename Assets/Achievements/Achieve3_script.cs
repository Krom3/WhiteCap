using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achieve3_script : MonoBehaviour {

    public static int achieveJobchangecount = 1;
    public Text achivetext;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (JopUpgrade_button1_script.jobchangecount >= achieveJobchangecount)
            {
                RightBackground_script.Crystal += 1;
                achieveJobchangecount += 1;
            }
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        achivetext.text = JopUpgrade_button1_script.jobchangecount + "/" + achieveJobchangecount;

    }
}
