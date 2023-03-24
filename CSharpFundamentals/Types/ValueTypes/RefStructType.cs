namespace CSharpFundamentals.Types.ValueTypes;

// A ref struct can't be the element type of an array.
// A ref struct can't be a declared type of a field of a class or a non-ref struct.
// A ref struct can't implement interfaces.
// A ref struct can't be boxed to System.ValueType or System.Object.
// A ref struct can't be a type argument.
// A ref struct variable can't be captured by a lambda expression or a local function.
// A ref struct variable can't be used in an async method. However, you can use ref struct variables in synchronous methods, for example, in methods that return Task or Task<TResult>.
// A ref struct variable can't be used in iterators.

public readonly ref struct RefStructType
{
    public RefStructType(double rate, ReadOnlySpan<double> values)
    {
        Rate = rate;
        Values = values;
    }

    public double Rate { get; }
    public ReadOnlySpan<double> Values { get; }
}