using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
public class StateManager : MonoBehaviour {

    public bool switchState = true;
    public float gameTimer;
    public int seconds = 0;

    public StateMachine<StateManager> stateMachine { get; set; }

    private void Start()
    {
        stateMachine = new StateMachine<StateManager>(this);
        stateMachine.ChangeState(FirstState.Instance);
        gameTimer = Time.time;
    }

    private void Update()
    {
        if(Time.time > gameTimer + 1)
        {
            gameTimer = Time.time;
            seconds++;
            Debug.Log("Seconds " + seconds);
        }
        if(seconds > 5)
        {
            seconds = 0;
            switchState = !switchState;
        }
        stateMachine.Update();
    }
}
