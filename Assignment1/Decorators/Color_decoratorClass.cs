using Assignment1.Interfaces;
using Assignment1.Components;

namespace Assignment1.Decorators;

    public class Color_decoratorClass : Decorator<string>
    {
        public Color_decoratorClass(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return $"\u001b[31m{base.GetText()}\u001b[0m";
        }
    }

