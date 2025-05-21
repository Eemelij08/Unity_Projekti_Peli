using UnityEngine;

public class HiiriHaviaa : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pistelaskuri.Instance.Hiiri == 1)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible=true;
        }

    }
}
