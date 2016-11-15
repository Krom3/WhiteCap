using UnityEngine;
using System.Collections;

public class Startwhitecap : MonoBehaviour
{
    public float LoadingTime = 3.0f;
    public AudioSource titlebgm;
    public GameObject whitecap, canvas,background,title,starthelper;
    private int justone=0;
    
    void Start ()
    {
        title.SetActive(false);
        starthelper.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

    }
    void FixedUpdate()
    {
        LoadingTime -= Time.deltaTime;

        if (LoadingTime <= 0 && justone==0)
        {
            whitecap.SetActive(false);
            canvas.SetActive(false);
            background.SetActive(false);
            title.SetActive(true);
            starthelper.SetActive(true);
            titlebgm.Play();
            justone++;
        }
    }
}
