Console.WriteLine("Choose an example to run.");
Action action = NicksAction;

// now we can call the method by invoking the variable:
action();
action.Invoke(); // either way works!

void NicksAction()
{
    Console.WriteLine("Hello from Nick!");
}
Func<int, int, int> addFunction = AddFunction;
Func<int, int, int> subtractFunction = SubtractFunction;

int AddFunction(int a, int b)
{
    return a + b;
}

int SubtractFunction(int a, int b)
{
    return a - b;
}
void DoSomethingAfterUserPressesEnter(Action callback)
{
    Console.WriteLine("Press enter for a surprise!");
    Console.ReadLine();
    callback();
}

DoSomethingAfterUserPressesEnter(NicksAction);
void Calculate(Func<int, int, int> calculateCallback)
{
    Console.WriteLine("Enter the first integer: ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second integer: ");
    int b = int.Parse(Console.ReadLine());

    int result = calculateCallback(a, b);
    Console.WriteLine($"The result is: {result}");
}

Console.WriteLine("Addition Example:");
Calculate(addFunction);
Console.WriteLine("Subtraction Example:");
Calculate(subtractFunction);
