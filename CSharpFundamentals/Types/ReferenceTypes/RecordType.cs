using System.Threading.Channels;

namespace CSharpFundamentals.Types.ReferenceTypes;

public record RecordType
{
    public RecordType()
    {
    }
    
    public RecordType(string name, uint age)
    {
        Name = name;
        Age = age;
    }
    
    public string Name { get; init; }
    
    public uint Age { get; init; }

}

public record RecordType2(string Name, uint Age, string[] Values);

public class RecordTypeClient
{
    public static void TryOut()
    {
        RecordType recordType = new RecordType(name: "Test Record", age: 99);
        
        RecordType recordType1 = new RecordType
        {
            Name = "Test Record",
            Age = 99
        };
        
        RecordType2 recordType2 = new RecordType2("Test Record", 99, new[] { "Value1", "Value2" });
        
        Console.WriteLine(recordType.Equals(recordType1)
            ? $"{nameof(recordType)} is equal to {nameof(recordType1)}"
            : $"{nameof(recordType)} is not equal to {nameof(recordType1)}");
        
        Console.WriteLine(recordType1.Equals(recordType2)
            ? $"{nameof(recordType1)} is equal to {nameof(recordType2)}"
            : $"{nameof(recordType1)} is not equal to {nameof(recordType2)}");
    }
}