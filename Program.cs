Console.Write("Type the element count for calculating the average of fibonacci sequence: ");
var count = Convert.ToInt32(Console.ReadLine());

Fibonacci fibonacci = new Fibonacci(count);
List<int> fibonacciList = fibonacci.GetSequence();
double fibonacciAverage = fibonacci.GetAverage();

System.Console.WriteLine("\nFibonacci Sequence");
System.Console.WriteLine("==================");

foreach(int item in fibonacciList)
{
    System.Console.WriteLine($"##### {item} #####");
}

System.Console.WriteLine("==================");

System.Console.WriteLine("\nAverage");
System.Console.WriteLine("==================");
System.Console.WriteLine(fibonacciAverage);
System.Console.WriteLine("==================\n");
