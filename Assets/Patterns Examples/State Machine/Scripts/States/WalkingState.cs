using UnityEngine;

namespace Assets.Patterns_Examples.State_Machine.Scripts.States
{
    public class WalkingState : State
    {
        private bool walking;
        private bool hitting;
        private float forwardMoving, rightMoving;

        public WalkingState(Character character, StateMachine stateMachine) : base(character, stateMachine)
        {
        }

        public override void Enter()
        {
            walking = true;
            hitting = false;
        }
        public override void HandleInput()
        {
            forwardMoving = 0;
            rightMoving = 0;

            if (Input.GetKey(KeyCode.W))
            {
                forwardMoving += 1;
            }
            if (Input.GetKey(KeyCode.A))
            {
                rightMoving -= 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                forwardMoving -= 1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                rightMoving += 1;
            }
            if (forwardMoving == 0 && rightMoving == 0)
            {
                walking = false;
            }
            hitting = Input.GetKey(KeyCode.E);
        }
        public override void LogicUpdate()
        {
            if (walking is false)
            {
                stateMachine.ChangeState(character.Standing);
            }
            else if (hitting)
            {
                character.Anim.SetBool(Animator.StringToHash("IsHitting"), true);
                stateMachine.ChangeState(character.Hitting);
            }
            else
            {
                character.Move((forwardMoving + 0.3f) * character.WalkingSpeed, 
                    rightMoving * character.RotationSpeed);
            }
        }
        public override void Exit()
        {
            character.Anim.SetBool(Animator.StringToHash("IsWalking"), false);
            character.ResetMoveParams();
        }
    }
}