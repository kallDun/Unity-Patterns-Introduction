using System.Threading.Tasks;

namespace Assets.Patterns_Examples.Composite_Pattern.Scripts.Abilities
{
    abstract class Ability
    {
        public abstract Task Use();
    }
}