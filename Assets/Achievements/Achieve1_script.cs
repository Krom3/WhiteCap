using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achieve1_script : MonoBehaviour
{
    public static int achieveclearcount = 1;
    public Text achivetext;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Capture_script.stageclearcount >= achieveclearcount)
            { RightBackground_script.Crystal += 1; }
            achieveclearcount++;
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        achivetext.text = Capture_script.stageclearcount + "/" + achieveclearcount;
    }
}
