using Assets.Patterns_Examples.Decorator_Pattern.Scripts.Utils;

namespace Assets.Patterns_Examples.Decorator_Pattern.Scripts
{
    public class CheeseBurgerMenu : BurgerMenu
    {
        public CheeseBurgerMenu(string name) : base(name)
        {
        }

        public override int GetCaloriesCount() => 650;

        public override void Show()
        {
            BurgerMenuAssetsStore.Spawner.Spawn(
                BurgerMenuAssetsStore.BurgerCheeseType, 
                BurgerMenuAssetsStore.BurgerSpawnPlace.transform);
        }
    }
}