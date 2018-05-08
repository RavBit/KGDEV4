using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
using System;
public class FirstState : State<StateManager>
{
    private static FirstState _instance;

    private FirstState()
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static FirstState Instance
    {
        get {
            if(_instance == null)
            {
                new FirstState();
            }
            return _instance;
        }

    }
    public override void EnterState(StateManager _owner)
    {
        Debug.Log("Entering First State");
    }

    public override void ExitState(StateManager _owner)
    {
        Debug.Log("Exiting First State");
    }

    public override void UpdateState(StateManager _owner)
    {
        if (!_owner.switchState)
        {
            _owner.stateMachine.ChangeState(SecondState.Instance);
        }
    }
}
