using UnityEngine;

namespace Assets.Patterns_Examples.State_Machine.Scripts.States
{
    public class HittingState : State
    {
        private float time;
        public HittingState(Character character, StateMachine stateMachine) : base(character, stateMachine)
        {
        }
        public override void LogicUpdate()
        {
            time += Time.deltaTime;
            if (time >= character.HitTime)
            {
                stateMachine.ChangeState(character.Standing);
            }
        }
        public override void Exit()
        {
            character.Anim.SetBool(Animator.StringToHash("IsHitting"), false);
        }
    }
}