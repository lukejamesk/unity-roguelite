using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillSetter : MonoBehaviour
{
    public int CurrentHealth;
    public IntVariable Max;

    public Image Image;
    public Entity Enemy;
    void Update()
    {
    }

    public void HealthChange(EntityHealthChangeData data)
    {
        if (Enemy.GetInstanceID() == data.Enemy.GetInstanceID())
        {
            var fillAmount = Mathf.Clamp01((float)data.Health / (float)Max.Value);
            Image.fillAmount = fillAmount;
        }

    }
}
