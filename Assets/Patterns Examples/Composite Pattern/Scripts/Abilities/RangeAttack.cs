using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Patterns_Examples.Composite_Pattern.Scripts.Abilities
{
    class RangeAttack : Ability
    {
        public override async Task Use()
        {
            int delayTime = new System.Random().Next(10, 100);
            await Task.Delay(delayTime);
            Debug.Log("Do mega range attack!");
        }
    }
}