using System.Collections.Generic;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    [SerializeField] private VoidEvent _onGameStartEvent;
    [SerializeField] private List<Variable> _variables;
    [SerializeField] private IntEvent _onPlayerDamageTaken;

    private void Start()
    {
        _onGameStartEvent.Raise();
        _onPlayerDamageTaken.Raise(10);
    }

    public void TestVariables()
    {
        foreach (Variable variable in _variables)
            Debug.Log(variable.ToString());
    }
}