using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitPortrait : MonoBehaviour
{
    public Unit Unit;

    public SpriteRenderer spriteRenderer;

    private void Start()
    {
      spriteRenderer.sprite = Unit.portrait;
    }
}
