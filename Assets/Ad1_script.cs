using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using System.Collections;

public class Ad1_script : MonoBehaviour
{
    public static int adcount = 0;
    public string id = "1178006";
    ShowOptions showopt = new ShowOptions();
    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    void OnAdsShowResultCallBack(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            RightBackground_script.Crystal += 1;
            adcount += 1;
            SaveGame_script.savegame();
        }
    }
    // Use this for initialization
    void Start()
    {
        Advertisement.Initialize(id, true);
        showopt.resultCallback = OnAdsShowResultCallBack;

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Advertisement.isInitialized)
            {
                Advertisement.Show(null, showopt);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    