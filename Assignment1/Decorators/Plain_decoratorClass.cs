using Assignment1.Interfaces;
using Assignment1.Components;

namespace Assignment1.Decorators;

public class Plain_decoratorClass : Decorator<string>
{
    public Plain_decoratorClass(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        return "Professor name: Brent Retchie. " + base.GetText();
    }
}
