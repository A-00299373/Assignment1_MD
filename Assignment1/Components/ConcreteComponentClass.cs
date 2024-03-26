using Assignment1.Interfaces;

namespace Assignment1.Components;

    public class ConcreteComponentClass : IComponent<string>
    {
        public string GetText()
        {
            return "This is the first assignment of Modular Development";
        }
    }

