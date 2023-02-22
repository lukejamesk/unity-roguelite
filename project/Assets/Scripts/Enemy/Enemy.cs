using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Unit Unit;

    void Awake()
    {
        Unit = Instantiate(Unit);
    }


    void Update()
    {
    }

}
