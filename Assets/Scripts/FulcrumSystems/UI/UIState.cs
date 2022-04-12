using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FulcrumSystems.StateMachine;

[System.Serializable]
public class UIState : SimpleState
{
    [HideInInspector]
    public UIStateMachine uIStateMachine;
}
