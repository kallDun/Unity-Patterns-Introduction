using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Patterns_Examples.Bridge_Pattern.Scripts
{
    class YellowCoreComponent : CoreComponent
    {
        public float RotationSpeed = 1f;
        protected override void Start()
        {
            base.Start();
            SetMeshColor(Color.gray);
        }
        private void Update()
        {
            if (is_activated)
            {
                transform.RotateAround(target, new Vector3(0, 1, 0), RotationSpeed);
            }
        }
        public override void ChangeColor()
        {
            SetMeshColor(Color.yellow);
        }
    }
}