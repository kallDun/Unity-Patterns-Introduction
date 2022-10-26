using UnityEngine;

namespace Assets.Patterns_Examples.State_Machine.Scripts.States
{
    public class StandingState : State
    {
        private bool walking;
        private bool hitting;

        public StandingState(Character character, StateMachine stateMachine) : base(character, stateMachine)
        {
        }

        public override void Enter()
        {
            walking = false;
            hitting = false;
        }
        public override void HandleInput()
        {
            walking = Input.GetKey(KeyCode.W) 
                || Input.GetKey(KeyCode.A) 
                || Input.GetKey(KeyCode.S) 
                || Input.GetKey(KeyCode.D);
            hitting = Input.GetKey(KeyCode.E);
        }
        public override void LogicUpdate()
        {
            if (walking)
            {
                character.Anim.SetBool(Animator.StringToHash("IsWalking"), true);
                stateMachine.ChangeState(character.Walking);
            }
            else if (hitting)
            {
                character.Anim.SetBool(Animator.StringToHash("IsHitting"), true);
                stateMachine.ChangeState(character.Hitting);
            }
        }
    }
}