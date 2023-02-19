using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private bool isInBattle = false;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsInBattle()
    {
        return isInBattle;
    }

    public void BeginBattle(List<Enemy> enemies)
    {
        isInBattle = true;

        enemies.ForEach(enemy => enemy.BeginBattle());
    }
}
