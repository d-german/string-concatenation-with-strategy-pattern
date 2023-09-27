using System.Text;

namespace StringConcatStrategyApp;

public interface IStringConcatStrategy
{
    string GenerateGreeting(Person person);
}

public class PlusOperatorStrategy : IStringConcatStrategy
{
    public string GenerateGreeting(Person person)
    {
        return "Hello, " + person.FirstName + " " + person.LastName + "!";
    }
}

public class StringBuilderStrategy : IStringConcatStrategy
{
    public string GenerateGreeting(Person person)
    {
        var builder = new StringBuilder();
        builder.Append("Hello, ").Append(person.FirstName).Append(" ").Append(person.LastName).Append("!");
        return builder.ToString();
    }
}

public class StringFormatStrategy : IStringConcatStrategy
{
    public string GenerateGreeting(Person person)
    {
        return string.Format("Hello, {0} {1}!", person.FirstName, person.LastName);
    }
}

public class StringInterpolationStrategy : IStringConcatStrategy
{
    public string GenerateGreeting(Person person)
    {
        return $"Hello, {person.FirstName} {person.LastName}!";
    }
}