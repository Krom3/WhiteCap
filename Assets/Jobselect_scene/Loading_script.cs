using UnityEngine;
using System.Collections;

public class Loading_script : MonoBehaviour {

    public float LoadingTime = 4.0f;
    public AudioSource loadingbgm;
    public AudioSource loadingbgm2;
    public GameObject LoadingWindow;
    public GameObject LoadingBar;
    public GameObject canvas;


	// Use this for initialization
	void Start ()
    {
        if (Effectsound_script.effectmute == false)
        {
            loadingbgm.volume = 0;
        }
        else if (Effectsound_script.effectmute == true)
        {
            loadingbgm.volume = 1;
        }
        canvas.SetActive(false);
        loadingbgm.Play();

	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0.048f, 0, 0);
	}

    void FixedUpdate()
    {
        LoadingTime -= Time.deltaTime;

        if (LoadingTime <= 0)
        {
            if (Effectsound_script.effectmute == false)
            {
                loadingbgm2.volume = 0;
            }
            else if (Effectsound_script.effectmute == true)
            {
                loadingbgm2.volume = 1;
            }
            loadingbgm.Stop();
            loadingbgm2.Play();
            canvas.SetActive(true);
            LoadingBar.SetActive(false);
            LoadingWindow.SetActive(false);
        }
    }
}


