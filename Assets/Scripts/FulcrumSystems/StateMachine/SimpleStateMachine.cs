using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace FulcrumSystems.StateMachine
{
    public class SimpleStateMachine : MonoBehaviour
    {
        [Header("States")]
        [HideInInspector]
        public List<SimpleState> States;
        public string StateName;
        protected SimpleState state = null;

        private void SetState(SimpleState s)
        {
            if (s == null)
                return;

            if (state != null)
                state.OnExit();

            state = s;

            state.OnStart();
        }

        public void ChangeState(string stateName)
        {
            foreach(SimpleState _state in States)
            {
                if (stateName.ToLower() == _state.GetType().ToString().ToLower())
                {
                    SetState(_state);
                    Debug.Log("State Changed: " + nameof(_state));
                    StateName = stateName;

                    return;
                }
            }

            // Same as above statement (will cover next class)
            IEnumerable<SimpleState> st = States.Where(_state => _state.GetType().ToString().ToLower() == stateName.ToLower());
        }

        private void FixedUpdate()
        {
            if (state == null)
                return;

            state.UpdateState(Time.deltaTime);
        }
    }
}
