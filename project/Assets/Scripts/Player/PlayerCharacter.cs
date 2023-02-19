using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerCharacter : MonoBehaviour
{
    void Start()
    {
        EventBus.Register<List<Enemy>>(EventConstants.PLAYER_ENEMY_APPROACHED, beginBattle);
    }

    public void beginBattle(List<Enemy> enemies)
    {
        GameManager.instance.BeginBattle(enemies);
    }

}
