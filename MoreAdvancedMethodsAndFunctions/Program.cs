Console.WriteLine("Choose an example to run.");
Action action = NicksAction;

// now we can call the method by invoking the variable:
action();
action.Invoke(); // either way works!

void NicksAction()
{
    Console.WriteLine("Hello from Nick!");
}