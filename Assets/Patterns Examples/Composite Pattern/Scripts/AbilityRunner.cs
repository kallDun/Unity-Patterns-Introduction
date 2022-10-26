using Assets.Patterns_Examples.Composite_Pattern.Scripts.Abilities;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Patterns_Examples.Composite_Pattern.Scripts
{
    public class AbilityRunner : MonoBehaviour
    {
        void Start()
        {
            List<Ability> abilities = new()
            {
                new PowerAttack(),
                new PowerAttack(),
                new RangeAttack(),
                new DelayedAbility(new PowerAttack(), 1000)
            };
            Ability parallelAbility = new SequenceParallelAbility(abilities);
            Ability consistenceAbility = new SequenceAbility(new() { parallelAbility, 
                new DelayedAbility(new RangeAttack(), 1000) });

            consistenceAbility.Use();
        }
    }
}