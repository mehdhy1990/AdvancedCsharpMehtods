Console.WriteLine("hello world ");
Lazy<int> lazyValue = new Lazy<int>(() =>
{
    Console.WriteLine("This will only run once.");
    Console.WriteLine("Finding the max...");
    int[] numbers = [35, 20, 30, 40, 50];

    int max = int.MinValue;
    foreach (var number in numbers)
    {
        if (number > max)
        {
            max = number;
           
        }

        // pretend this is an expensive operation
        Thread.Sleep(1000);
    }

    Console.WriteLine("The max value is: " + max);
    return max;
});

Console.WriteLine("The value of lazyValue is: " + lazyValue.Value);
