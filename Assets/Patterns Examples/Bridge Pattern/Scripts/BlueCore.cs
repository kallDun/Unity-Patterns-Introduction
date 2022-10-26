using UnityEngine;

namespace Assets.Patterns_Examples.Bridge_Pattern.Scripts
{
    class BlueCore : Core
    {
        public override void ChangePosition()
        {
            gameObject.transform.position = new Vector3(1, 1, 1);
        }
    }
}