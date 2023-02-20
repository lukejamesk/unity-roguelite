using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    public Unit unit;
    private int _health = 100;
    public int health { get => _health; set => _health = health; }

    void Awake()
    {
    }


    void Update()
    {
    }

}
