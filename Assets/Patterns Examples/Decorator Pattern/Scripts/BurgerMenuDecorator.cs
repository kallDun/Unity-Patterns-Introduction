namespace Assets.Patterns_Examples.Decorator_Pattern.Scripts
{
    public abstract class BurgerMenuDecorator : BurgerMenu
    {
        protected BurgerMenu burgerMenu;
        protected BurgerMenuDecorator(string name, BurgerMenu burgerMenu) : base(name)
        {
            this.burgerMenu = burgerMenu;
        }
    }
}