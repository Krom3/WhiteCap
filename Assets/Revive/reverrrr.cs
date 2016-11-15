using UnityEngine;
using System.Collections;

public class reverrrr : MonoBehaviour
{
    public float LoadingTime = 0.1f;

    SpriteRenderer render;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        LoadingTime -= Time.deltaTime;
        if (LoadingTime < 0)
        {
            render.color = new Color(255, Random.value, 0, Random.value);
            LoadingTime = 0.1f;
        }
    }
}