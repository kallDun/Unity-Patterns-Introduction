using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assets.Patterns_Examples.Composite_Pattern.Scripts.Abilities
{
    class SequenceParallelAbility : Ability
    {
        private List<Ability> abilities;
        public SequenceParallelAbility(List<Ability> abilities)
        {
            this.abilities = abilities;
        }

        public override async Task Use()
        {
            List<Task> abilitiesActions = new();
            foreach (var ability in abilities)
            {
                abilitiesActions.Add(ability.Use());
            }
            await Task.WhenAll(abilitiesActions);
        }
    }
}