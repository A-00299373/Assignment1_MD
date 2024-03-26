using Assignment1.Components;
using Assignment1.Decorators;
using Assignment1.Interfaces;

IComponent<string> component = new ConcreteComponentClass();

var plainDecorator = new Plain_decoratorClass(component);
var uppercaseDecorator = new Uppercase_decoratorClass(component);
var colorDecorator = new Color_decoratorClass(component);

Console.WriteLine("First Decorator(Prefix): " + plainDecorator.GetText());
Console.WriteLine("Second Decorator(Uppercase): " + uppercaseDecorator.GetText());
Console.WriteLine("Third Decorator(Color): " + colorDecorator.GetText());


