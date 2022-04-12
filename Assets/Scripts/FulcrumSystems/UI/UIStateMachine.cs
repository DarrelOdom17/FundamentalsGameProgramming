using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FulcrumSystems.StateMachine;

public class UIStateMachine : SimpleStateMachine
{
    public UIHUDState uIHUDState;
    public UIPauseState uIPauseState;

    void Start()
    {
        States.Add(uIPauseState);
        States.Add(uIHUDState);

        uIHUDState.uIStateMachine = this;
        uIPauseState.uIStateMachine = this;
        

        foreach(SimpleState state in States)
        {
            state.StateMachine = this;
        }

        ChangeState(nameof(uIHUDState));
    }

    private void Update()
    {
        
    }

    public void PauseButton()
    {
        ChangeState(nameof(uIPauseState));
    }

    public void ResumeButton()
    {
        ChangeState(nameof(uIHUDState));
    }
}
