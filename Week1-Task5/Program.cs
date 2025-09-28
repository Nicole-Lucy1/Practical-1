evenOddChecker();
void evenOddChecker()
{
    Console.WriteLine("Please enter an integer");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.WriteLine("Your number is even");
    }
    else
    {
        Console.WriteLine("Your number is odd");
    }
}
