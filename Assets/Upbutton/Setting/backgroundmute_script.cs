using UnityEngine;
using System.Collections;

public class backgroundmute_script : MonoBehaviour {

    public bool bgmonff=true;
    public AudioSource click;
    public AudioSource bgmsystem;
    public GameObject bgmon;
    public GameObject bgmoff;
    // Use this for initialization
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            click.Play();
            if (bgmonff == true)
            {
                bgmonff = false;
                bgmsystem.Play();
                bgmon.SetActive(true);
                bgmoff.SetActive(false);
            }
            else if (bgmonff == false)
            {
                bgmonff = true;
                bgmsystem.Stop();
                bgmoff.SetActive(true);
                bgmon.SetActive(false);
            }
        }
    }
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
    }
}
