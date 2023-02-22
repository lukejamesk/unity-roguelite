using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerCharacter : MonoBehaviour
{
    public GameObject battleMenu;

    void Start()
    {
        EventBus.Register<List<OverworldEnemy>>(EventConstants.PLAYER_ENEMY_APPROACHED, BeginBattle);

    }

    private void Update()
    {
    }

    public void BeginBattle(List<OverworldEnemy> enemies)
    {
    }
}
