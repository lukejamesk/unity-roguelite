using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillSetter : MonoBehaviour
{
    public IntVariable Variable;
    public IntVariable Max;

    public Image Image;
    void Update()
    {
        var fillAmount = Mathf.Clamp01((float)Variable.Value / (float)Max.Value);
        Debug.Log(Variable.Value);
        Debug.Log(Max.Value);
        Debug.Log(fillAmount);
        Debug.Log("===");
        Image.fillAmount = fillAmount;
    }
}
