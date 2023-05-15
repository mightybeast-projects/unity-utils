using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGameEvent<T> : ScriptableObject
{
    private readonly  List<IGameEventListener<T>> _listeners = new List<IGameEventListener<T>>();
    
    public void Raise(T t)
    {
        foreach (var listener in _listeners)
        {
            listener.OnEventRaised(t);
        }
    }
    
    public void RegisterListener(IGameEventListener<T> listener)
    {
        if(!_listeners.Contains(listener)) _listeners.Add(listener);
    }
    
    public void UnregisterListener(IGameEventListener<T> listener)
    {
        if(_listeners.Contains(listener)) _listeners.Remove(listener);
    }
}