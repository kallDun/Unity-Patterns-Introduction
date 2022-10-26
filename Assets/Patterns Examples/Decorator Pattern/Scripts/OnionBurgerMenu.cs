using Assets.Patterns_Examples.Decorator_Pattern.Scripts.Utils;

namespace Assets.Patterns_Examples.Decorator_Pattern.Scripts
{
    public class OnionBurgerMenu : BurgerMenu
    {
        public OnionBurgerMenu(string name) : base(name)
        {
        }

        public override int GetCaloriesCount() => 700;

        public override void Show()
        {
            BurgerMenuAssetsStore.Spawner.Spawn(
                BurgerMenuAssetsStore.BurgerBigOnionType, 
                BurgerMenuAssetsStore.BurgerSpawnPlace.transform);
        }
    }
}