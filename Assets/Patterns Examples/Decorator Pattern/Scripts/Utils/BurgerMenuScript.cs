using UnityEngine;

namespace Assets.Patterns_Examples.Decorator_Pattern.Scripts.Utils
{
    public class BurgerMenuScript : MonoBehaviour
    {
        public BurgerMenuUIScript UIScript;

        public GameObject BurgerType1, BurgerType2;
        public GameObject CocaCola;
        public GameObject FrenchFries;
        public GameObject BurgerSpawnPlace, DrinkSpawnPlace, FriesSpawnPlace;

        void Start()
        {
            BurgerMenuAssetsStore.Spawner = this;
            BurgerMenuAssetsStore.BurgerCheeseType = BurgerType1;
            BurgerMenuAssetsStore.BurgerBigOnionType = BurgerType2;
            BurgerMenuAssetsStore.CocaCola = CocaCola;
            BurgerMenuAssetsStore.FrenchFries = FrenchFries;
            BurgerMenuAssetsStore.BurgerSpawnPlace = BurgerSpawnPlace;
            BurgerMenuAssetsStore.DrinkSpawnPlace = DrinkSpawnPlace;
            BurgerMenuAssetsStore.FriesSpawnPlace = FriesSpawnPlace;
        }
        public void Spawn(GameObject obj, Transform parent)
        {
            Instantiate(obj, parent);
        }
        public void CreateMenu()
        {
            BurgerMenu burgerMenu;

            if (UIScript.Burger1.isOn)
            {
                burgerMenu = new CheeseBurgerMenu("Cheese burger menu");
            }
            else
            {
                burgerMenu = new OnionBurgerMenu("Onion big burger menu");
            }
            if (UIScript.Drink.isOn)
            {
                burgerMenu = new BurgerMenuDrink(burgerMenu);
            }
            if (UIScript.FriedPotato.isOn)
            {
                burgerMenu = new BurgerMenuFries(burgerMenu);
            }

            ClearOldMenu();
            burgerMenu.Show();

            print($"{burgerMenu.Name} with {burgerMenu.GetCaloriesCount()} calories.");
        }

        private void ClearOldMenu()
        {
            DestroyChildrenIn(BurgerSpawnPlace);
            DestroyChildrenIn(DrinkSpawnPlace);
            DestroyChildrenIn(FriesSpawnPlace);
        }
        private static void DestroyChildrenIn(GameObject parent)
        {
            foreach (Transform child in parent.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }
}