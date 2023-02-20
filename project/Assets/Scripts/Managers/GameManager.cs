using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private bool isInBattle = false;

    public BattleSystem battleManager;

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

    public void BeginBattle(List<OverworldEnemy> enemies)
    {
        isInBattle = true;
        StartCoroutine(battleManager.InitializeBattle(enemies));

    }
}
