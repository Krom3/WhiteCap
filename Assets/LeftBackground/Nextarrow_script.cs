using UnityEngine;
using System.Collections;

public class Nextarrow_script : MonoBehaviour
{
    public AudioSource NextArrowCS;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            NextArrowCS.Play();
            LeftBackgruond_script.Chapternum++;
        }
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
