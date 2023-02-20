using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerCharacter : MonoBehaviour
{
    public GameObject battleMenu;

    private bool battleMenuActive = false;
    void Start()
    {
        EventBus.Register<List<OverworldEnemy>>(EventConstants.PLAYER_ENEMY_APPROACHED, BeginBattle);

    }

    private void Update()
    {
        if (GameManager.instance.IsInBattle())
        {
            if (battleMenuActive == false)
            {
                Instantiate(battleMenu, new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y - 1), Quaternion.identity);
                battleMenuActive = true;
            }
        } else {
            if (battleMenuActive)
            {
                Destroy(battleMenu);
                battleMenuActive = false;
            }
        }
    }

    public void BeginBattle(List<OverworldEnemy> enemies)
    {
        GameManager.instance.BeginBattle(enemies);
    }

}
