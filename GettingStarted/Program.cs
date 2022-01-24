using e2.Framework.Components;
using GettingStarted;

var registry = new CoreIOCRegistry();
registry.Register<IMyComponent>().AsSingletonOf<MyComponent>();

var factory = registry.Factory;

var myComponent = factory.GetInstanceOf<IMyComponent>();

Console.WriteLine(
    $"Implemented type: {myComponent.GetType()}\n" +
    $"Concatenated result is \"{myComponent.Concatenate("Hello ", "World!")}\".");

Console.WriteLine("\nPress any key to exit the application.");
Console.ReadKey(true);