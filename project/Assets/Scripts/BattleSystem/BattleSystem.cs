using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using Random = UnityEngine.Random;

public enum BattleState {  START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    public int TurnOrderPredictions = 16;

    public Entity PlayerCharacter;
    public EnemySpawner enemySpawner;

    private BattleState state;

    private List<Entity> enemies;
    private List<Entity> battleParticipantEntities = new List<Entity>();
    private List<BattleParticipant> battleParticipants = new List<BattleParticipant>();

    private List<Entity> ActualTurnOrder = new List<Entity>();
    private List<Entity> PredictedTurnOrder = new List<Entity>();


    public UnityEvent<List<Entity>> TurnOrderCalculatedEvent;
    public UnityEvent BattleFinishedEvent;

    // Start is called before the first frame update
    void Start()
    {
    }

    
    public IEnumerator SetupBattle(CollisionData collisionData)
    {
        state = BattleState.START;
        enemies = enemySpawner.SpawnEnemiesFrom(collisionData);

        battleParticipantEntities.Add(PlayerCharacter);
        battleParticipantEntities.AddRange(enemies);

        battleParticipantEntities.ForEach(battleParticipantEntity => battleParticipants.Add(battleParticipantEntity.battleParticipant));

        yield return StartCoroutine(BeginBattlePhase());
    }

    public IEnumerator BeginBattlePhase()
    {
        TurnCalculate();
        var enemiesDead = true;
        if (enemies.Find(enemy => enemy.IsAlive())) {
            enemiesDead = false;
        }
        if (enemiesDead)
        {
            state = BattleState.WON;
            BattleFinishedEvent.Invoke();
            enemies.ForEach(enemy => Destroy(enemy.gameObject));
            yield return null;
        }

        if (ActualTurnOrder[0] == PlayerCharacter)
        {
            state = BattleState.PLAYERTURN;
            yield return StartCoroutine(BeginPlayerTurn(ActualTurnOrder[0]));
        }
        else
        {
            state = BattleState.ENEMYTURN;
            yield return StartCoroutine(BeginEnemyTurn(ActualTurnOrder[0]));
        }


    }

    public IEnumerator BeginPlayerTurn(Entity entity)
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("PLAYER TURN");
        var enemiesAlive = enemies.FindAll(enemy => enemy.IsAlive());
        enemiesAlive.ToArray()[(Random.Range(0, enemiesAlive.Count() - 1))].DealDamage(20);
        FinishTurn();
        yield return StartCoroutine(BeginBattlePhase());
    }

    public IEnumerator BeginEnemyTurn(Entity entity)
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("ENEMY TURN");
        PlayerCharacter.DealDamage(2);
        FinishTurn();
        yield return StartCoroutine(BeginBattlePhase());
    }

    public void InitBattle(CollisionData collisionData)
    {
        StartCoroutine(SetupBattle(collisionData));
    }

    public void FinishTurn()
    {
        ActualTurnOrder.Remove(ActualTurnOrder[0]);
        TurnCalculate();
    }
    void TurnCalculate()
    {
        ActualTurnOrder = RunTurnCalculation(1, battleParticipants);
        PredictedTurnCalculate();
    }

    void PredictedTurnCalculate()
    {
        PredictedTurnOrder = PredictNextTurns(TurnOrderPredictions);
        TurnOrderCalculatedEvent.Invoke(PredictedTurnOrder);
    }

    private List<Entity> RunTurnCalculation(int turnsToCalculate, List<BattleParticipant> participants)
    {
        List<Entity> turns = new List<Entity>();

        ActualTurnOrder.ForEach(entity => turns.Add(entity));

        var turnsCount = turns.Count();
        while (turnsCount < turnsToCalculate)
        {
            participants.ForEach(participant =>
            {
                if (turnsCount < turnsToCalculate)
                {
                    var turnTicked = participant.TickTurn();
                    if (turnTicked)
                    {
                        var found = battleParticipantEntities.Find(battleParticipant => battleParticipant.GetInstanceID() == participant.Id);
                        turns.Add(found);
                        turnsCount = turns.Count();
                    }
                }

            });
        }
        return turns;
    }

    private List<Entity> PredictNextTurns(int turnsToPredict)
    {
        List<BattleParticipant> participants = new List<BattleParticipant>();

        battleParticipants.ForEach(participant =>
        {
            participants.Add(
                new BattleParticipant(
                    participant.TickCounter,
                    participant.TickSpeed,
                    participant.Speed,
                    participant.Id
                )
            );
        });

        participants.OrderBy(participant => participant.TickCounter);

        return RunTurnCalculation(turnsToPredict, participants);
    }

    public int CalculateTurnTick(int tickCounter, int speed, int tickSpeed)
    {
        return tickCounter = tickCounter - (tickSpeed + speed);
    }

}
