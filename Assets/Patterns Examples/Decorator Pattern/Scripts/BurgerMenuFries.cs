using Assets.Patterns_Examples.Decorator_Pattern.Scripts.Utils;

namespace Assets.Patterns_Examples.Decorator_Pattern.Scripts
{
    public class BurgerMenuFries : BurgerMenuDecorator
    {
        public BurgerMenuFries(BurgerMenu burgerMenu) : base(burgerMenu.Name + " with fries", burgerMenu)
        {
        }

        public override int GetCaloriesCount()
        {
            return burgerMenu.GetCaloriesCount() + 286;
        }

        public override void Show()
        {
            burgerMenu.Show();
            BurgerMenuAssetsStore.Spawner.Spawn(
                BurgerMenuAssetsStore.FrenchFries, 
                BurgerMenuAssetsStore.FriesSpawnPlace.transform);
        }
    }
}