using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;


[AddComponentMenu("Game Events/Argument Game Event Listener")]
[System.Serializable]
public class ArgumentGameEventListener<T> : MonoBehaviour
{

    public ArgumentGameEvent<T> Event;
    public UnityEvent<T> Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(T e)
    {
        Response.Invoke(e);
    }

}
