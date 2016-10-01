using System.Collections.Generic;

public abstract class FSMState {

    FiniteStateMachine fsm;
    List<Transition> transitions;

    public void AddTransition(Transition transition)
    {
        transitions.Add(transition);
    }

    public void AssignFSM(FiniteStateMachine finiteStateMachine)
    {
        fsm = finiteStateMachine;
    }

    public FSMState FindNextState(string sentCondition)
    {
        for (int i = 0; i < transitions.Count; i++)
            if (transitions[i].Condition.Equals(sentCondition))
                return transitions[i].NextState;

        return null;
    }

    public virtual void Start()
    {

    }

    public virtual void Update()
    {

    }

    public virtual void End()
    {

    }
}
