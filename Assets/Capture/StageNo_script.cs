using UnityEngine;
using System.Collections;

public class StageNo_script : MonoBehaviour {

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            StageQuestion_script.StageQuestionoff = false;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
    