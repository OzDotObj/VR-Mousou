using UnityEngine;

public class AoiManager : MonoBehaviour
{
    void Start()
    {
        iTween.RotateTo(gameObject, iTween.Hash("y", 180f, "time", 5.0f, "delay", 10.0f));
    }

    void Update()
    {
        
    }
}
