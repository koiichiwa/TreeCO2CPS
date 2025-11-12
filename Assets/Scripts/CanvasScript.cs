using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
[RequireComponent(typeof(CanvasScaler))]
public class CanvasScript : MonoBehaviour
{
    public float referenceWidth = 1080f;
    public float referenceHeight = 1920f;

    void Update()
    {
        var scaler = GetComponent<CanvasScaler>();
        float currentAspect = (float)Screen.width / Screen.height;
        float referenceAspect = referenceWidth / referenceHeight;


        if (currentAspect > referenceAspect)
        {
            scaler.matchWidthOrHeight = 1f; 
            scaler.referenceResolution = new Vector2(referenceWidth, referenceHeight);
        }
        else
        {
            scaler.matchWidthOrHeight = 1f;
        }
    }
}
