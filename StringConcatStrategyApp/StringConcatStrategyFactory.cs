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
                // TODO: return new StringBuilderStrategy();
            case 3:
                // TODO: return new StringFormatStrategy();
            case 4:
                // TODO: return new StringInterpolationStrategy();
            default:
                return new PlusOperatorStrategy();
        }
    }
}