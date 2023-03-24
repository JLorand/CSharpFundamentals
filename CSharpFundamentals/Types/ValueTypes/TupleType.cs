namespace CSharpFundamentals.Types.ValueTypes;

// The tuples feature provides concise syntax to group multiple data elements in a lightweight data structure. 

public class TupleType
{
    public static (int min, int max) FindMinMax(int[] input)
    {
        if (input is null || input.Length == 0)
        {
            throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
        }

        var min = int.MaxValue;
        var max = int.MinValue;
        foreach (var i in input)
        {
            if (i < min)
            {
                min = i;
            }
            if (i > max)
            {
                max = i;
            }
        }
        return (min, max);
    }
}