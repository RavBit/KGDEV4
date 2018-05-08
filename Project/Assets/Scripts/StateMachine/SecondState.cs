using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
using System;
public class SecondState : State<StateManager>
{
    private static SecondState _instance;

    private SecondState()
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static SecondState Instance {
        get {
            if (_instance == null)
            {
                new SecondState();
            }
            return _instance;
        }

    }
    public override void EnterState(StateManager _owner)
    {
        Debug.Log("Entering Second State");
    }

    public override void ExitState(StateManager _owner)
    {
        Debug.Log("Exiting Second State");
    }

    public override void UpdateState(StateManager _owner)
    {
        if(_owner.switchState)
        {
            _owner.stateMachine.ChangeState(FirstState.Instance);
        }
    }
}
