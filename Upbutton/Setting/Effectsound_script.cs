using UnityEngine;
using System.Collections;

public class Effectsound_script : MonoBehaviour {
    public static bool effectmute=true;
    public AudioSource click;
    public AudioSource click2;
    public GameObject effecton;
    public GameObject effectoff;
    // Use this for initialization
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (effectmute == true)
            {
                effectmute = false;
                click.volume = 0;
                click2.volume = 0;
                effectoff.SetActive(true);
                effecton.SetActive(false);
            }
            else if (effectmute == false)
            {
                effectmute = true;
                click.volume = 1;
                click2.volume = 1;
                click.Play();
                effecton.SetActive(true);
                effectoff.SetActive(false);
            }
        }
    }
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
