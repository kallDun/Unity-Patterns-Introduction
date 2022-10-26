namespace Assets.Patterns_Examples.Decorator_Pattern.Scripts
{
    public abstract class BurgerMenu
    {
        protected BurgerMenu(string name)
        {
            Name = name;
        }
        public string Name { get; protected set; }
        public abstract void Show();
        public abstract int GetCaloriesCount();
    }
}