namespace Assets.Patterns_Examples.State_Machine.Scripts
{
    public abstract class State
    {
        protected Character character;
        protected StateMachine stateMachine;

        protected State(Character character, StateMachine stateMachine)
        {
            this.character = character;
            this.stateMachine = stateMachine;
        }

        public virtual void Enter() { }

        public virtual void HandleInput() { }

        public virtual void LogicUpdate() { }

        public virtual void PhysicsUpdate() { }

        public virtual void Exit() { }
    }
}