using Assignment1.Interfaces;
using Assignment1.Components;

namespace Assignment1.Decorators;

public class Uppercase_decoratorClass : Decorator<string>
{
    public Uppercase_decoratorClass(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}

