using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


[CreateAssetMenu(fileName = "FloatReference", menuName = "Variables/Float Reference")]
[Serializable]
public class FloatReference : ScriptableObject
{
    public bool UseConstant = true;
    public float ConstantValue;
    public FloatVariable Variable;

    public float Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }
}
