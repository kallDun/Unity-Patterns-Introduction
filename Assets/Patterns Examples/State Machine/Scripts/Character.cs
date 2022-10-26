using Assets.Patterns_Examples.State_Machine.Scripts.States;
using UnityEngine;

namespace Assets.Patterns_Examples.State_Machine.Scripts
{
    public class Character : MonoBehaviour
    {
        public StateMachine StateMachine;
        public StandingState Standing;
        public WalkingState Walking;
        public HittingState Hitting;

        public Animator Anim;

        public float WalkingSpeed = 250;
        public float RotationSpeed = 250;
        public float HitTime = 2.5f;

        private void Start()
        {
            StateMachine = new StateMachine();

            Standing = new StandingState(this, StateMachine);
            Walking = new WalkingState(this, StateMachine);
            Hitting = new HittingState(this, StateMachine);

            StateMachine.Initialize(Standing);
        }
        private void Update()
        {
            StateMachine.CurrentState.HandleInput();

            StateMachine.CurrentState.LogicUpdate();
        }
        private void FixedUpdate()
        {
            StateMachine.CurrentState.PhysicsUpdate();
        }

        public void Move(float speed, float rotationSpeed)
        {
            Vector3 targetVelocity = speed * transform.forward * Time.deltaTime;
            targetVelocity.y = GetComponent<Rigidbody>().velocity.y;
            GetComponent<Rigidbody>().velocity = targetVelocity;
            GetComponent<Rigidbody>().angularVelocity = rotationSpeed * Vector3.up * Time.deltaTime;
        }

        public void ResetMoveParams()
        {
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;            
        }
    }
}