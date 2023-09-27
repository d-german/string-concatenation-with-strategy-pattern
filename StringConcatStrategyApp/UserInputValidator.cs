namespace StringConcatStrategyApp;

public static class UserInputValidator
{
    public static bool IsValidChoice(string? input, out int choice)
    {
        var isValidInt = int.TryParse(input, out choice);
        
        const int minChoice = 1;
        const int maxChoice = 4;
        return isValidInt && choice is >= minChoice and <= maxChoice;
    }
}