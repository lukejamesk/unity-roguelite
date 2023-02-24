using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOrderDisplayer : MonoBehaviour
{
    public GameObject PortraitContainer;
    public GameObject PortraitPrefab;
    public void SetTurnOrder(List<Entity> entities)
    {
        Debug.Log("Setting Turn Order");
        Debug.Log(entities);
        var currentChildrenCount = PortraitContainer.transform.childCount;

        for (int i = currentChildrenCount - 1; i >= 0; i--)
        {
            DestroyImmediate(PortraitContainer.transform.GetChild(i).gameObject);
        }

        entities.ForEach((entity) =>
        {
            var newPortrait = Instantiate(PortraitPrefab, PortraitContainer.transform);
            var unitPortrait = newPortrait.GetComponent<UnitPortrait>();
            unitPortrait.Unit = entity.Unit;
        });
    }
}
