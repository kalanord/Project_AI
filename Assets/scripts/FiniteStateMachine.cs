using System.Collections.Generic;

public class FiniteStateMachine {

    FSMState currentState;
    List<FSMState> possibleStates;

    public void AddState(FSMState state)
    {
        possibleStates.Add(state);
    }

    public void Update()
    {
        currentState.Update();
    }

    public void ChangeState(string condition)
    {
        currentState.End();
        currentState = currentState.FindNextState(condition);
        currentState.Start();
    }
}
