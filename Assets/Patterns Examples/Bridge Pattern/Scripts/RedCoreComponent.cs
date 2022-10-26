using UnityEngine;

namespace Assets.Patterns_Examples.Bridge_Pattern.Scripts
{
    public class RedCoreComponent : CoreComponent
    {
        public float RequiredDistance = .01f;
        public float Speed = 1f;

        protected override void Start()
        {
            base.Start();
            SetMeshColor(Color.gray);
        }
        void Update()
        {
            if (is_activated)
            {
                var offset = target - transform.position;
                if (offset.magnitude >= RequiredDistance)
                {
                    transform.position += Speed * Time.deltaTime * offset.normalized;
                }
            }
        }
        public override void ChangeColor()
        {
            SetMeshColor(Color.red);
        }
    }
}