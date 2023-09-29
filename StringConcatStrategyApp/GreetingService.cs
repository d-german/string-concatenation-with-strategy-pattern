namespace StringConcatStrategyApp;

public class GreetingService
{
    // TODO: Declare a private readonly field of type IStringConcatStrategy.
    // This will hold the strategy implementation.

    // TODO: Add a constructor that takes an IStringConcatStrategy parameter
    // and assigns it to the private field.

    public GreetingService()
    {
        // TODO: Initialize the private readonly field in the constructor.
    }

    public void DisplayGreeting(Person person)
    {
        // TODO: Replace the following line with a call to the GenerateGreeting method 
        // from the strategy object. The method should return a greeting string that you will
        // display using Console.WriteLine.

        // The following line is all you need in this method.
        // Console.WriteLine(_strategy.GenerateGreeting(person));

        throw new NotImplementedException();
    }
}