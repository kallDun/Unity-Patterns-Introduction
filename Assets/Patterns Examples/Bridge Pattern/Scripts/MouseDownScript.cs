using UnityEngine;

namespace Assets.Patterns_Examples.Bridge_Pattern.Scripts
{
    class MouseDownScript : MonoBehaviour
    {
        public Core coreObject;

        private void OnMouseDown()
        {
            coreObject.ChangePosition();
            coreObject.ActivateComponents();
        }
    }
}