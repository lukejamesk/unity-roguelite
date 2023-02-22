using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "ArgumentGameEvent", menuName = "Events/ArgumentGameEvent")]
public class ArgumentGameEvent<T> : ScriptableObject
{
    private List<ArgumentGameEventListener<T>> listeners = new List<ArgumentGameEventListener<T>>();

    public void Raise(T data)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(data);
        }
    }

    public void RegisterListener(ArgumentGameEventListener<T> listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(ArgumentGameEventListener<T> listener)
    {
        listeners.Remove(listener);
    }
}
