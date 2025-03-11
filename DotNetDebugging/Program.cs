using System.Diagnostics;

int result = Fibonacci(6);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"We are looking for the {n}th number");
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
    }
    
    Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");
    return n == 0 ? n1 : n2;
}

int IntegerDivide(int dividend, int divisor)
{
    Console.WriteLine("This message is readable by the end user.");
    Trace.WriteLine("This is a trace message when tracing the app.");
    Debug.WriteLine("This is a debug message just for developers.");
    Debug.Write("Debug - ");
    Debug.WriteLine("This is a full line.");
    Debug.WriteLine("This is another full line.");
    int count = 0;
    Debug.WriteLineIf(count == 0, "The count is 0 and this may cause an exception.");
    bool errorFlag = false;
    Trace.WriteIf(errorFlag, "Error in AppendData procedure.");
    Debug.WriteIf(errorFlag, "Transaction abandoned.");
    Trace.Write("Invalid value for data request");
    Debug.Assert(divisor != 0, $"{nameof(divisor)} is 0 and will cause an exception.");

    return dividend / divisor;
}

/*
Fibonacci(0) = 0
Fibonacci(1) = 1
Fibonacci(2) = 1 (0 + 1)
Fibonacci(3) = 2 (1 + 1)
Fibonacci(4) = 3 (1 + 2)
Fibonacci(5) = 5 (2 + 3)
*/