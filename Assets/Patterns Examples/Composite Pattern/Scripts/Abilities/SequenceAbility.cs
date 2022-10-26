using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assets.Patterns_Examples.Composite_Pattern.Scripts.Abilities
{
    class SequenceAbility : Ability
    {
        private List<Ability> abilities;
        public SequenceAbility(List<Ability> abilities)
        {
            this.abilities = abilities;
        }

        public override async Task Use()
        {
            foreach (var ability in abilities)
            {
                await ability.Use();
            }
        }
    }
}