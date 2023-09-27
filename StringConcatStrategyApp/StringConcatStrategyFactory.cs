namespace StringConcatStrategyApp;

public static class StringConcatStrategyFactory
{
    public static IStringConcatStrategy CreateStrategy(int choice)
    {
        switch (choice)
        {
            case 1:
                return new PlusOperatorStrategy();
            case 2:
                return new StringBuilderStrategy();
            case 3:
                return new StringFormatStrategy();
            case 4:
                return new StringInterpolationStrategy();
            default:
                return new PlusOperatorStrategy();
        }
    }
}