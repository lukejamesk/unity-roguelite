using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


[CreateAssetMenu(fileName = "IntReference", menuName = "Variables/Int Reference")]
[Serializable]
public class IntReference : ScriptableObject
{
    public bool UseConstant = true;
    public int ConstantValue;
    public IntVariable Variable;

    public int Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }
}
