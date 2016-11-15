using UnityEngine;
using System.Collections;

public class Beforarrow_script : MonoBehaviour
{
    public AudioSource BeforeArrowCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            LeftBackgruond_script.Chapternum--;
            BeforeArrowCS.Play();
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
