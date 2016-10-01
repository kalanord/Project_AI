public class Transition {

    FSMState nextState;
    string condition;

    public Transition(FSMState nextState, string condition)
    {
        this.nextState = nextState;
        this.condition = condition;
    }

    public FSMState NextState
    {
        get
        {
            return nextState;
        }
    }

    public string Condition
    {
        get
        {
            return condition;
        }
    }

}
