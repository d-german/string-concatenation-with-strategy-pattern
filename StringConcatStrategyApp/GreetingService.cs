namespace StringConcatStrategyApp;

public class GreetingService
{
    private readonly IStringConcatStrategy _strategy;

    public GreetingService(IStringConcatStrategy strategy)
    {
        _strategy = strategy;
    }

    public void DisplayGreeting(Person person)
    {
        Console.WriteLine(_strategy.GenerateGreeting(person));
    }
}