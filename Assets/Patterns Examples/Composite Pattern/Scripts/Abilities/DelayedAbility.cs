using System.Threading.Tasks;

namespace Assets.Patterns_Examples.Composite_Pattern.Scripts.Abilities
{
    class DelayedAbility : Ability
    {
        private Ability ability;
        private int delayMilliSeconds;
        public DelayedAbility(Ability ability, int delayMilliSeconds)
        {
            this.ability = ability;
            this.delayMilliSeconds = delayMilliSeconds;
        }

        public override async Task Use()
        {
            await Task.Delay(delayMilliSeconds);
            await ability.Use();
        }
    }
}