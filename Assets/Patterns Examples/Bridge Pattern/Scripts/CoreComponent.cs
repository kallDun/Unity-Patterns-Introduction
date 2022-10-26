using System;
using UnityEngine;

namespace Assets.Patterns_Examples.Bridge_Pattern.Scripts
{
    public abstract class CoreComponent : MonoBehaviour
    {
        public MeshRenderer Mesh;
        protected bool is_activated;
        protected Vector3 target;
        protected virtual void Start()
        {
            target = new Vector3(0, 0, 0);
        }
        public virtual void Activate()
        {
            is_activated = true;
        }
        public virtual void SetNewTarget(Vector3 target)
        {
            this.target = target;
        }
        public abstract void ChangeColor();
        protected void SetMeshColor(Color color)
        {
            Mesh.material.color = color;
        }
    }
}