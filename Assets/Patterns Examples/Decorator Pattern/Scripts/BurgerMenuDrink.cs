using Assets.Patterns_Examples.Decorator_Pattern.Scripts.Utils;

namespace Assets.Patterns_Examples.Decorator_Pattern.Scripts
{
    public class BurgerMenuDrink : BurgerMenuDecorator
    {
        public BurgerMenuDrink(BurgerMenu burgerMenu) : base(burgerMenu.Name + " with drink", burgerMenu)
        {
        }

        public override int GetCaloriesCount()
        {
            return burgerMenu.GetCaloriesCount() + 380;
        }

        public override void Show()
        {
            burgerMenu.Show();
            BurgerMenuAssetsStore.Spawner.Spawn(
                BurgerMenuAssetsStore.CocaCola, 
                BurgerMenuAssetsStore.DrinkSpawnPlace.transform);
        }
    }
}