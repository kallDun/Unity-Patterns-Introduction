using System.Collections.Generic;
using UnityEngine;
namespace Assets.Patterns_Examples.Bridge_Pattern.Scripts
{
    public abstract class Core : MonoBehaviour
    {
        public List<CoreComponent> Components;

        public virtual void ActivateComponents()
        {
            foreach (var component in Components)
            {
                component.SetNewTarget(transform.position);
                component.ChangeColor();
                component.Activate();
            }
        }
        public abstract void ChangePosition();
    }
}