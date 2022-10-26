using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Patterns_Examples.Composite_Pattern.Scripts.Abilities
{
    class PowerAttack : Ability
    {
        public override async Task Use()
        {
            int delayTime = new System.Random().Next(10, 100);
            await Task.Delay(delayTime);
            Debug.Log("Do power attack!");
        }
    }
}