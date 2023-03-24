namespace CSharpFundamentals.Types.ReferenceTypes;

public class StringLiteralType
{
    public static string Greet(string name = "Developer")
    {
        return $"""Hello, fellow {name}!""";
    }
}